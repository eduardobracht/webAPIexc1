using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProdutosWebApi.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("exercapi") { }
        public DbSet<Product> Products { get; set; }
    }
}