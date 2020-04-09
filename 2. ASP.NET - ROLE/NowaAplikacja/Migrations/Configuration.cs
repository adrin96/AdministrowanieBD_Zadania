namespace NowaAplikacja.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using NowaAplikacja.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<NowaAplikacja.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "NowaAplikacja.Models.ApplicationDbContext";
        }

        protected override void Seed(NowaAplikacja.Models.ApplicationDbContext context)
        {       
            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            string[] roleNames = { "Admin", "Teacher", "Student" };
            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                if (!RoleManager.RoleExists(roleName))
                {
                    roleResult = RoleManager.Create(new IdentityRole(roleName));
                }

            }

            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            //doda³em u¿ytkownika, którego stworzy³em jako admina, czyli admin@o2.pl
            UserManager.AddToRole("2cb2fee7-6ef3-4e28-aaf6-058a18078863", "Admin");

        }
    }
}
