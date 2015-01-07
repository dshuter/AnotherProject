//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using AnotherProject.Models;
//using System.Data.Entity;
//using System.Data.Entity.ModelConfiguration.Conventions;


//namespace AnotherProject.DAL
//{
//    public class SchoolContext
//    {
//        public DbSet<NStudent> NStudents { get; set; }
//        public DbSet<Enrollment> Enrollments { get; set; }
//        public DbSet<Course> Courses { get; set; }

//        protected override void OnModelCreating(DbModelBuilder modelBuilder)
//        {
//            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
//        }
//    }
//}