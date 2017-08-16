using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gummidom.Models;

namespace Gummidom.Models
{
    public class GummidomContext : DbContext

    {

        public GummidomContext()
        {

        }

        public virtual DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Gummidom;integrated security=True");
        }

        public GummidomContext(DbContextOptions<GummidomContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
