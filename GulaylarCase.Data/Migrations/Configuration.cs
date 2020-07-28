using GulaylarCase.Data.Models;

namespace GulaylarCase.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GulaylarCase.Data.Models.GulaylarDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GulaylarCase.Data.Models.GulaylarDb context)
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


            context.Course.AddOrUpdate(
                new Course
                {
                    Id = 1, Title = "Course Name 1", Slug = "Course Name 1", Description = "Course Name 1",
                    VideoUrl = "Course Name 1", DateAdded = DateTime.Now
                },
                new Course
                {
                    Id = 2, Title = "Course Name 2", Slug = "Course Name 2", Description = "Course Name 2",
                    VideoUrl = "Course Name 2", DateAdded = DateTime.Now
                },
                new Course
                {
                    Id = 3, Title = "Course Name 3", Slug = "Course Name 3", Description = "Course Name 3",
                    VideoUrl = "Course Name 3", DateAdded = DateTime.Now
                }
            );



            context.Role.AddOrUpdate(
                new Role {Id = 1, Name = "User", DateAdded = DateTime.Now},
                new Role {Id = 2, Name = "Admin", DateAdded = DateTime.Now}
            );



            context.User.AddOrUpdate(
                new User
                {
                    Id = 1, FirstName = "Hakan", LastName = "GÜZEL", Email = "hakan-guzel@outlook.com",
                    Password = "22610", RoleId = 1, DateAdded = DateTime.Now
                },
                new User
                {
                    Id = 2, FirstName = "Leanne", LastName = "Graham", Email = "Sincere@april.biz", Password = "92998",
                    RoleId = 1, DateAdded = DateTime.Now
                },
                new User
                {
                    Id = 3, FirstName = "Ervin", LastName = "Howell", Email = "Shanna@melissa.tv", Password = "90566",
                    RoleId = 1, DateAdded = DateTime.Now
                },
                new User
                {
                    Id = 4, FirstName = "Clementine", LastName = "Bauch", Email = "Nathan@yesenia.net",
                    Password = "59590", RoleId = 1, DateAdded = DateTime.Now
                },
                new User
                {
                    Id = 5, FirstName = "Patricia", LastName = "Lebsack", Email = "Julianne.OConner@kory.org",
                    Password = "53919", RoleId = 1, DateAdded = DateTime.Now
                },
                new User
                {
                    Id = 6, FirstName = "Chelsey", LastName = "Dietrich", Email = "Lucio_Hettinger@annie.ca",
                    Password = "33263", RoleId = 1, DateAdded = DateTime.Now
                },
                new User
                {
                    Id = 7, FirstName = "Dennis", LastName = "Schulist", Email = "Karley_Dach@jasper.info",
                    Password = "23505", RoleId = 1, DateAdded = DateTime.Now
                },
                new User
                {
                    Id = 8, FirstName = "Kurtis", LastName = "Weissnat", Email = "Telly.Hoeger@billy.biz",
                    Password = "58804", RoleId = 1, DateAdded = DateTime.Now
                },
                new User
                {
                    Id = 9, FirstName = "Nicholas", LastName = "Runolfsdottir", Email = "Sherwood@rosamond.me",
                    Password = "45169", RoleId = 1, DateAdded = DateTime.Now
                },
                new User
                {
                    Id = 10, FirstName = "Glenna", LastName = "Reichert", Email = "Chaim_McDermott@dana.io",
                    Password = "59590", RoleId = 1, DateAdded = DateTime.Now
                },
                new User
                {
                    Id = 11, FirstName = "Clementina", LastName = "DuBuque", Email = "Rey.Padberg@karina.biz",
                    Password = "31428", RoleId = 1, DateAdded = DateTime.Now
                }
            );




            context.Subscribe.AddOrUpdate(
                new Subscribe { UserId = 1, CourseId = 1, DateAdded = DateTime.Now },
                new Subscribe { UserId = 1, CourseId = 2, DateAdded = DateTime.Now },
                new Subscribe { UserId = 1, CourseId = 3, DateAdded = DateTime.Now },
                new Subscribe { UserId = 2, CourseId = 1, DateAdded = DateTime.Now },
                new Subscribe { UserId = 2, CourseId = 3, DateAdded = DateTime.Now },
                new Subscribe { UserId = 3, CourseId = 2, DateAdded = DateTime.Now },
                new Subscribe { UserId = 4, CourseId = 1, DateAdded = DateTime.Now },
                new Subscribe { UserId = 4, CourseId = 2, DateAdded = DateTime.Now },
                new Subscribe { UserId = 4, CourseId = 3, DateAdded = DateTime.Now },
                new Subscribe { UserId = 5, CourseId = 1, DateAdded = DateTime.Now },
                new Subscribe { UserId = 5, CourseId = 2, DateAdded = DateTime.Now },
                new Subscribe { UserId = 6, CourseId = 1, DateAdded = DateTime.Now },
                new Subscribe { UserId = 7, CourseId = 1, DateAdded = DateTime.Now },
                new Subscribe { UserId = 8, CourseId = 3, DateAdded = DateTime.Now },
                new Subscribe { UserId = 9, CourseId = 1, DateAdded = DateTime.Now },
                new Subscribe { UserId = 9, CourseId = 2, DateAdded = DateTime.Now },
                new Subscribe { UserId = 9, CourseId = 3, DateAdded = DateTime.Now },
                new Subscribe { UserId = 10, CourseId = 1, DateAdded = DateTime.Now },
                new Subscribe { UserId = 10, CourseId = 2, DateAdded = DateTime.Now },
                new Subscribe { UserId = 10, CourseId = 3, DateAdded = DateTime.Now },
                new Subscribe { UserId = 11, CourseId = 1, DateAdded = DateTime.Now },
                new Subscribe { UserId = 11, CourseId = 2, DateAdded = DateTime.Now },
                new Subscribe { UserId = 11, CourseId = 3, DateAdded = DateTime.Now }
            );



            context.WatchHistory.AddOrUpdate(
                new WatchHistory { UserId = 1, CourseId = 1, DateAdded = DateTime.Now },
                new WatchHistory { UserId = 1, CourseId = 2, DateAdded = DateTime.Now },
                new WatchHistory { UserId = 1, CourseId = 3, DateAdded = DateTime.Now },
                new WatchHistory { UserId = 2, CourseId = 1, DateAdded = DateTime.Now },
                new WatchHistory { UserId = 2, CourseId = 3, DateAdded = DateTime.Now },
                new WatchHistory { UserId = 3, CourseId = 2, DateAdded = DateTime.Now },
                new WatchHistory { UserId = 4, CourseId = 1, DateAdded = DateTime.Now },
                new WatchHistory { UserId = 4, CourseId = 2, DateAdded = DateTime.Now },
                new WatchHistory { UserId = 4, CourseId = 3, DateAdded = DateTime.Now },
                new WatchHistory { UserId = 5, CourseId = 1, DateAdded = DateTime.Now },
                new WatchHistory { UserId = 5, CourseId = 2, DateAdded = DateTime.Now },
                new WatchHistory { UserId = 6, CourseId = 1, DateAdded = DateTime.Now },
                new WatchHistory { UserId = 7, CourseId = 1, DateAdded = DateTime.Now },
                new WatchHistory { UserId = 8, CourseId = 3, DateAdded = DateTime.Now },
                new WatchHistory { UserId = 9, CourseId = 1, DateAdded = DateTime.Now },
                new WatchHistory { UserId = 9, CourseId = 2, DateAdded = DateTime.Now },
                new WatchHistory { UserId = 9, CourseId = 3, DateAdded = DateTime.Now },
                new WatchHistory { UserId = 10, CourseId = 1, DateAdded = DateTime.Now },
                new WatchHistory { UserId = 10, CourseId = 2, DateAdded = DateTime.Now },
                new WatchHistory { UserId = 10, CourseId = 3, DateAdded = DateTime.Now },
                new WatchHistory { UserId = 11, CourseId = 1, DateAdded = DateTime.Now },
                new WatchHistory { UserId = 11, CourseId = 2, DateAdded = DateTime.Now },
                new WatchHistory { UserId = 11, CourseId = 3, DateAdded = DateTime.Now },




                new WatchHistory { UserId = 1, CourseId = 1, DateAdded = DateTime.Now.AddDays(-1) },
                new WatchHistory { UserId = 1, CourseId = 2, DateAdded = DateTime.Now.AddDays(-1) },
                new WatchHistory { UserId = 1, CourseId = 3, DateAdded = DateTime.Now.AddDays(-1) },
                new WatchHistory { UserId = 2, CourseId = 1, DateAdded = DateTime.Now.AddDays(-1) },
                new WatchHistory { UserId = 2, CourseId = 3, DateAdded = DateTime.Now.AddDays(-1) },
                new WatchHistory { UserId = 3, CourseId = 2, DateAdded = DateTime.Now.AddDays(-1) },
                new WatchHistory { UserId = 4, CourseId = 1, DateAdded = DateTime.Now.AddDays(-1) },
                new WatchHistory { UserId = 4, CourseId = 2, DateAdded = DateTime.Now.AddDays(-1) },
                new WatchHistory { UserId = 4, CourseId = 3, DateAdded = DateTime.Now.AddDays(-1) },
                new WatchHistory { UserId = 5, CourseId = 1, DateAdded = DateTime.Now.AddDays(-1) },
                new WatchHistory { UserId = 5, CourseId = 2, DateAdded = DateTime.Now.AddDays(-1) },
                new WatchHistory { UserId = 6, CourseId = 1, DateAdded = DateTime.Now.AddDays(-1) },
                new WatchHistory { UserId = 7, CourseId = 1, DateAdded = DateTime.Now.AddDays(-1) },
                new WatchHistory { UserId = 8, CourseId = 3, DateAdded = DateTime.Now.AddDays(-1) },
                new WatchHistory { UserId = 9, CourseId = 1, DateAdded = DateTime.Now.AddDays(-1) },
                new WatchHistory { UserId = 9, CourseId = 2, DateAdded = DateTime.Now.AddDays(-1) },
                new WatchHistory { UserId = 9, CourseId = 3, DateAdded = DateTime.Now.AddDays(-1) },
                new WatchHistory { UserId = 10, CourseId = 1, DateAdded = DateTime.Now.AddDays(-1) },
                new WatchHistory { UserId = 10, CourseId = 2, DateAdded = DateTime.Now.AddDays(-1) },
                new WatchHistory { UserId = 10, CourseId = 3, DateAdded = DateTime.Now.AddDays(-1) },
                new WatchHistory { UserId = 11, CourseId = 1, DateAdded = DateTime.Now.AddDays(-1) },
                new WatchHistory { UserId = 11, CourseId = 2, DateAdded = DateTime.Now.AddDays(-1) },
                new WatchHistory { UserId = 11, CourseId = 3, DateAdded = DateTime.Now.AddDays(-1) },




                new WatchHistory { UserId = 1, CourseId = 1, DateAdded = DateTime.Now.AddDays(-2) },
                new WatchHistory { UserId = 1, CourseId = 2, DateAdded = DateTime.Now.AddDays(-2) },
                new WatchHistory { UserId = 1, CourseId = 3, DateAdded = DateTime.Now.AddDays(-2) },
                new WatchHistory { UserId = 2, CourseId = 1, DateAdded = DateTime.Now.AddDays(-2) },
                new WatchHistory { UserId = 2, CourseId = 3, DateAdded = DateTime.Now.AddDays(-2) },
                new WatchHistory { UserId = 3, CourseId = 2, DateAdded = DateTime.Now.AddDays(-2) },
                new WatchHistory { UserId = 4, CourseId = 1, DateAdded = DateTime.Now.AddDays(-2) },
                new WatchHistory { UserId = 4, CourseId = 2, DateAdded = DateTime.Now.AddDays(-2) },
                new WatchHistory { UserId = 4, CourseId = 3, DateAdded = DateTime.Now.AddDays(-2) },
                new WatchHistory { UserId = 5, CourseId = 1, DateAdded = DateTime.Now.AddDays(-2) },
                new WatchHistory { UserId = 5, CourseId = 2, DateAdded = DateTime.Now.AddDays(-2) },
                new WatchHistory { UserId = 6, CourseId = 1, DateAdded = DateTime.Now.AddDays(-2) },
                new WatchHistory { UserId = 7, CourseId = 1, DateAdded = DateTime.Now.AddDays(-2) },
                new WatchHistory { UserId = 8, CourseId = 3, DateAdded = DateTime.Now.AddDays(-2) },
                new WatchHistory { UserId = 9, CourseId = 1, DateAdded = DateTime.Now.AddDays(-2) },
                new WatchHistory { UserId = 9, CourseId = 2, DateAdded = DateTime.Now.AddDays(-2) },
                new WatchHistory { UserId = 9, CourseId = 3, DateAdded = DateTime.Now.AddDays(-2) },
                new WatchHistory { UserId = 10, CourseId = 1, DateAdded = DateTime.Now.AddDays(-2) },
                new WatchHistory { UserId = 10, CourseId = 2, DateAdded = DateTime.Now.AddDays(-2) },
                new WatchHistory { UserId = 10, CourseId = 3, DateAdded = DateTime.Now.AddDays(-2) },
                new WatchHistory { UserId = 11, CourseId = 1, DateAdded = DateTime.Now.AddDays(-2) },
                new WatchHistory { UserId = 11, CourseId = 2, DateAdded = DateTime.Now.AddDays(-2) },
                new WatchHistory { UserId = 11, CourseId = 3, DateAdded = DateTime.Now.AddDays(-2) },




                new WatchHistory { UserId = 1, CourseId = 1, DateAdded = DateTime.Now.AddDays(-3) },
                new WatchHistory { UserId = 1, CourseId = 2, DateAdded = DateTime.Now.AddDays(-3) },
                new WatchHistory { UserId = 2, CourseId = 3, DateAdded = DateTime.Now.AddDays(-3) },
                new WatchHistory { UserId = 3, CourseId = 2, DateAdded = DateTime.Now.AddDays(-3) },
                new WatchHistory { UserId = 4, CourseId = 1, DateAdded = DateTime.Now.AddDays(-3) },
                new WatchHistory { UserId = 4, CourseId = 3, DateAdded = DateTime.Now.AddDays(-3) },
                new WatchHistory { UserId = 5, CourseId = 1, DateAdded = DateTime.Now.AddDays(-3) },
                new WatchHistory { UserId = 5, CourseId = 2, DateAdded = DateTime.Now.AddDays(-3) },
                new WatchHistory { UserId = 6, CourseId = 1, DateAdded = DateTime.Now.AddDays(-3) },
                new WatchHistory { UserId = 8, CourseId = 3, DateAdded = DateTime.Now.AddDays(-3) },
                new WatchHistory { UserId = 9, CourseId = 1, DateAdded = DateTime.Now.AddDays(-3) },
                new WatchHistory { UserId = 9, CourseId = 3, DateAdded = DateTime.Now.AddDays(-3) },
                new WatchHistory { UserId = 10, CourseId = 2, DateAdded = DateTime.Now.AddDays(-3) },
                new WatchHistory { UserId = 10, CourseId = 3, DateAdded = DateTime.Now.AddDays(-3) },
                new WatchHistory { UserId = 11, CourseId = 2, DateAdded = DateTime.Now.AddDays(-3) },
                new WatchHistory { UserId = 11, CourseId = 3, DateAdded = DateTime.Now.AddDays(-3) },




                new WatchHistory { UserId = 1, CourseId = 1, DateAdded = DateTime.Now.AddDays(-4) },
                new WatchHistory { UserId = 1, CourseId = 2, DateAdded = DateTime.Now.AddDays(-4) },
                new WatchHistory { UserId = 1, CourseId = 3, DateAdded = DateTime.Now.AddDays(-4) },
                new WatchHistory { UserId = 2, CourseId = 1, DateAdded = DateTime.Now.AddDays(-4) },
                new WatchHistory { UserId = 2, CourseId = 3, DateAdded = DateTime.Now.AddDays(-4) },
                new WatchHistory { UserId = 3, CourseId = 2, DateAdded = DateTime.Now.AddDays(-4) },
                new WatchHistory { UserId = 4, CourseId = 1, DateAdded = DateTime.Now.AddDays(-4) },
                new WatchHistory { UserId = 4, CourseId = 2, DateAdded = DateTime.Now.AddDays(-4) },
                new WatchHistory { UserId = 4, CourseId = 3, DateAdded = DateTime.Now.AddDays(-4) },
                new WatchHistory { UserId = 5, CourseId = 1, DateAdded = DateTime.Now.AddDays(-4) },
                new WatchHistory { UserId = 5, CourseId = 2, DateAdded = DateTime.Now.AddDays(-4) },
                new WatchHistory { UserId = 6, CourseId = 1, DateAdded = DateTime.Now.AddDays(-4) },
                new WatchHistory { UserId = 7, CourseId = 1, DateAdded = DateTime.Now.AddDays(-4) },
                new WatchHistory { UserId = 8, CourseId = 3, DateAdded = DateTime.Now.AddDays(-4) },
                new WatchHistory { UserId = 9, CourseId = 1, DateAdded = DateTime.Now.AddDays(-4) },
                new WatchHistory { UserId = 9, CourseId = 2, DateAdded = DateTime.Now.AddDays(-4) },
                new WatchHistory { UserId = 9, CourseId = 3, DateAdded = DateTime.Now.AddDays(-4) },
                new WatchHistory { UserId = 10, CourseId = 1, DateAdded = DateTime.Now.AddDays(-4) },
                new WatchHistory { UserId = 10, CourseId = 2, DateAdded = DateTime.Now.AddDays(-4) },
                new WatchHistory { UserId = 10, CourseId = 3, DateAdded = DateTime.Now.AddDays(-4) },
                new WatchHistory { UserId = 11, CourseId = 1, DateAdded = DateTime.Now.AddDays(-4) },
                new WatchHistory { UserId = 11, CourseId = 2, DateAdded = DateTime.Now.AddDays(-4) },
                new WatchHistory { UserId = 11, CourseId = 3, DateAdded = DateTime.Now.AddDays(-4) }
            );




        }
    }
}
