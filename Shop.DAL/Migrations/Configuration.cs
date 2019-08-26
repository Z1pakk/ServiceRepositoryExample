namespace Shop.DAL.Migrations
{
    using Shop.DAL.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Shop.DAL.Entities.EFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Shop.DAL.Entities.EFContext context)
        {
            for (int i = 0; i < 10; i++)
            {
                Product product = new Product()
                {
                    Id = i + 1,
                    Name = "Салат " + i,
                    Price = i * 100,
                    DateCreate = DateTime.Now
                };
                context.Products.AddOrUpdate(
                    t => t.Id,
                    product);

            }
        }
    }
}
