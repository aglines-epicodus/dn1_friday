using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gummidom.Models
{
    [Table("Products")]

    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set;  }
        public decimal Cost { get; set; }
        public string CountryOfOrigin { get; set; }       
    }
}
