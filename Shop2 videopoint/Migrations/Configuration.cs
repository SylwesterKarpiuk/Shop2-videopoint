namespace Shop2_videopoint.Migrations
{
    using Shop2_videopoint.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Shop2_videopoint.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Shop2_videopoint.Models.ApplicationDbContext context)
        {
            context.Category.AddOrUpdate(c => c.Name, new Category { Name = "Kategoria g³ówna" }, new Category { Name = "Elektronika" });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
