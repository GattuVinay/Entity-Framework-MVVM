namespace Mini_projekat_2___Entity_Framework_MVVM.Migrations
{
    using Mini_projekat_2___Entity_Framework_MVVM.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Mini_projekat_2___Entity_Framework_MVVM.Data.MiniDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Mini_projekat_2___Entity_Framework_MVVM.Data.MiniDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data

            context.Students.AddOrUpdate(s => s.StudentId,
                new Student
                {
                    sFirstName = "Vinay",
                    sLastName = "Kumar",
                    Address = new Address { Address1 = "Hyderabad", City = "Hyderabad", Country = "India" },
                    Courses = new List<Course>
                    {
                        new Course
                        {
                            cName = "ECE"
                        },
                        new Course
                        {
                            cName = "EEE"
                        }
                    }
                },
                new Student
                {
                    sFirstName = "Anil",
                    sLastName = "Kumar",
                    Address = new Address { Address1 = "Nellor", City = "Hyderabad", Country = "India" },
                    Courses = new List<Course>
                    {
                        new Course
                        {
                            cName = "EEE"
                        },
                        new Course
                        {
                            cName = "CIVIL"
                        }
                    }
                },
                new Student
                {
                    sFirstName = "Kiran",
                    sLastName = "Gonugunta",
                    Address = new Address { Address1 = "India", City = "Hyderabad", Country = "India" },
                    Courses = new List<Course>
                    {
                        new Course
                        {
                            cName = "Mech"
                        },
                        new Course
                        {
                            cName = "Mech"
                        }
                    }
                },
                new Student
                {
                    sFirstName = "Marija",
                    sLastName = "Markovic",
                    Address = new Address { Address1 = "Ulica 2", City = "Grad 2", Country = "Zemlja 2" },
                    Courses = new List<Course>
                    {
                        new Course
                        {
                            cName = "Kurs1"
                        },
                        new Course
                        {
                            cName = "Kurs2"
                        },
                        new Course
                        {
                            cName = "Kurs3"
                        }
                    }
                }
                );
        }
    }
}
