namespace BabyStore.Migrations
{

    using Models;
    using System.Collections.Generic;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BabyStore.DAL.StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BabyStore.DAL.StoreContext";
        }

        protected override void Seed(BabyStore.DAL.StoreContext context)
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
            //


            var categories = new List<Category>
            {
                new Category{Name = "Clothes"},
                new Category { Name = "Play and Toys" },
                new Category { Name = "Feeding" },
                new Category { Name = "Medicine" },
                new Category { Name= "Travel" },
                new Category { Name= "Sleeping" }
            };

            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();


            var products = new List<Product>
            {
                new Product { Name = "Sleep Suit", Description="For sleeping or general wear",
                Price=4.99M, CategoryID=categories.Single( c => c.Name == "Clothes").ID },
                new Product { Name = "Vest", Description="For sleeping or general wear",
                Price=2.99M, CategoryID=categories.Single( c => c.Name ==
                "Clothes").ID },
                new Product { Name = "Orange and Yellow Lion", Description="Makes a squeaking noise", Price=1.99M, CategoryID=categories.Single( c => c.Name ==
                "Play and Toys").ID },
                new Product { Name = "Blue Rabbit", Description="Baby comforter", Price=2.99M,
                CategoryID=categories.Single(c => c.Name == "Play and Toys").ID
                    },

                new Product { Name = "3 Pack of Bottles", Description="For a leak free drink everytime", Price=24.99M, CategoryID=categories.Single( c =>
                c.Name == "Feeding").ID
                },
                new Product { Name = "3 Pack of Bibs", Description="Keep your baby when feeding", Price=8.99M, CategoryID=categories.Single( c => c.Name
                == "Feeding").ID },
                new Product { Name = "Powdered Baby Milk", Description="Nutritional Tasty", Price=9.99M, CategoryID=categories.Single( c => c.Name ==
                "Feeding").ID }
            };
        
  
            products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
               
        }
    }
}
