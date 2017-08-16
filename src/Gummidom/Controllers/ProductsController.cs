using Gummidom.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Extensions;
using System.ComponentModel.DataAnnotations;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Gummidom.Controllers
{
    public class ProductsController : Controller
    {
        private GummidomContext db = new GummidomContext();
        // GET: /<controller>/
        public IActionResult Index()
        {

            return View(db.Products.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisProduct = db.Products.FirstOrDefault(products => products.ProductId == id);
            return View(thisProduct);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {
            var thisProduct = db.Products.FirstOrDefault(products => products.ProductId == id);
            return View(thisProduct);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var thisProduct = db.Products.FirstOrDefault(products => products.ProductId == id);
            return View(thisProduct);
        }

        [HttpPost, ActionName("Delete")] 
        public IActionResult DeleteConfirmed(int id)
        {
            var thisProduct = db.Products.FirstOrDefault(products => products.ProductId == id);
            db.Products.Remove(thisProduct);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
