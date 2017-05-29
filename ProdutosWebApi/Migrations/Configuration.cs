namespace ProdutosWebApi.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProdutosWebApi.Models.ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProdutosWebApi.Models.ProductContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );

            context.Products.AddOrUpdate(
                new Product { Name = "Tomato soup", Category = "Groceries", Price = 1.39M },
                new Product { Name = "Yo-yo", Category = "Toys", Price = 3.75M },
                new Product { Name = "Hammer", Category = "Hardware", Price = 16.99M }
            );
        }
    }
}
