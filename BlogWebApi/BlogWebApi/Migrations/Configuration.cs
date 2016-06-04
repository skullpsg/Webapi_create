namespace BlogWebApi.Migrations
{
    using BlogWebApi.Entities;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BlogWebApi.Entities.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BlogWebApi.Entities.ApplicationDbContext context)
        {
            var manager = new UserManager<UserEntity>(new UserStore<UserEntity>(new ApplicationDbContext()));

            var user = new UserEntity()
            {
                UserName = "AdminUser",
                Email = "vishnusankar.sakthivel@mymail.com",
                EmailConfirmed = true,
                FirstName = "vishnu",
                LastName = "sankar",
                Level = 1,
                Company="SampleCompany1",
                JoinDate = DateTime.Now.AddYears(-3)
            };

            manager.Create(user, "Password1");
        }
    }
}
