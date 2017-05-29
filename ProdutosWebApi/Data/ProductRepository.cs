using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProdutosWebApi.Models;
using System.Data.Entity;

namespace ProdutosWebApi.Data
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>();
        private int _nextId = 1;

        public ProductRepository()
        {
        //    Add(new Product { Name = "Tomato soup", Category = "Groceries", Price = 1.39M });
        //    Add(new Product { Name = "Yo-yo", Category = "Toys", Price = 3.75M });
        //    Add(new Product { Name = "Hammer", Category = "Hardware", Price = 16.99M });
        }

        public Product Add(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            var pc = new ProductContext();
            pc.Products.Add(item);
            pc.SaveChanges();
            return item;
        }

        public Product Get(int id)
        {
            var pc = new ProductContext();
            var product = pc.Products.Find(id);
            return product;
        }

        public IEnumerable<Product> GetAll()
        {
            var pc = new ProductContext();
            var product = pc.Products.ToList();
            return product;
        }

        public void Remove(int id)
        {
            var pc = new ProductContext();
            var product = pc.Products.Find(id);
            if (product != null) pc.Products.Remove(product);
        }

        public bool Update(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            var pc = new ProductContext();
            pc.Entry(item).State = EntityState.Modified;
            return true;
        }
    }
}