using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2.Net21LinQKimWiklund.Models
{
    public class LabbDBContext : DbContext
    {
        
        public DbSet<Student> Students { get; set; }
        public DbSet<SchoolClass> SchoolClasses { get; set; }
        public DbSet<SchoolClassCourse> SchoolClassCourses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Data Source = DESKTOP-FARI6OS\\SQLEXPRESS;Initial Catalog=Labb2LinQDB;Integrated Security = True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasData(new Course
                {
                    CourseId = 1,
                    CourseName = "Math",
                    


                });
            modelBuilder.Entity<Course>()
                .HasData(new Course
                {
                    CourseId = 2,
                    CourseName = "Geography",
                    

                });
            modelBuilder.Entity<Course>()
                .HasData(new Course
                {
                    CourseId = 3,
                    CourseName = "English",
                    

                });
            modelBuilder.Entity<Course>()
                .HasData(new Course
                {
                    CourseId = 4,
                    CourseName = "Biology",
                    
                    
                });
            modelBuilder.Entity<Teacher>()
                .HasData(new Teacher
                {
                    TeacherId = 1,
                    FirstName = "Bengt",
                    LastName = "Svensson",
                    Age = 52,
                    Gender = "M",
                    fkCourseId = 1,

                });
            modelBuilder.Entity<Teacher>()
                .HasData(new Teacher
                {
                    TeacherId = 2,
                    FirstName = "Sara",
                    LastName = "Häggkvist",
                    Age = 42,
                    Gender = "F",
                    fkCourseId = 2

                });
            modelBuilder.Entity<Teacher>()
                .HasData(new Teacher
                {
                    TeacherId = 3,
                    FirstName = "Linus",
                    LastName = "Skalare",
                    Age = 38,
                    Gender = "M",
                    fkCourseId = 3

                });
            modelBuilder.Entity<SchoolClass>()
                .HasData(new SchoolClass
                {
                    SchoolClassId = 1,
                    SchoolClassName = "1A",
                    

                });
            modelBuilder.Entity<SchoolClass>()
                .HasData(new SchoolClass
                {
                    SchoolClassId = 2,
                    SchoolClassName = "2B",


                });

            modelBuilder.Entity<SchoolClassCourse>()
                 .HasData(new SchoolClassCourse
                 {
                     SchoolClassCourseId = 1,
                     fkSchoolClassId = 1,
                     fkCourseId = 1
                     
                 });
            modelBuilder.Entity<SchoolClassCourse>()
                 .HasData(new SchoolClassCourse
                 {
                     SchoolClassCourseId = 2,
                     fkSchoolClassId = 2,
                     fkCourseId = 2

                 });


            modelBuilder.Entity<Student>()
                .HasData(new Student
                {
                    StudentId = 1,
                    FirstName = "Adam",
                    LastName = "Jansson",
                    Age = 12,
                    Gender = "M",
                    fkSchoolClassId = 1,
                    fkStudentTeacherId = 1



                });
            modelBuilder.Entity<Student>()
                .HasData(new Student
                {
                    StudentId = 2,
                    FirstName = "Jenny",
                    LastName = "LindKvist",
                    Age = 12,
                    Gender = "F",
                    fkSchoolClassId = 1,
                    fkStudentTeacherId = 1



                });
            modelBuilder.Entity<Student>()
                .HasData(new Student
                {
                    StudentId = 3,
                    FirstName = "Marcus",
                    LastName = "Jonsson",
                    Age = 12,
                    Gender = "M",
                    fkSchoolClassId = 1,
                    fkStudentTeacherId = 1


                });
            modelBuilder.Entity<Student>()
                .HasData(new Student
                {
                    StudentId = 4,
                    FirstName = "Anna",
                    LastName = "Wiklund",
                    Age = 12,
                    Gender = "F",
                    fkSchoolClassId = 1,
                    fkStudentTeacherId = 1


                });
            modelBuilder.Entity<Student>()
                .HasData(new Student
                {
                    StudentId = 5,
                    FirstName = "Johannes",
                    LastName = "Öberg",
                    Age = 12,
                    Gender = "M",
                    fkSchoolClassId = 1,
                    fkStudentTeacherId = 1


                });
            modelBuilder.Entity<Student>()
                .HasData(new Student
                {
                    StudentId = 6,
                    FirstName = "Adam",
                    LastName = "Sundqvist",
                    Age = 12,
                    Gender = "M",
                    fkSchoolClassId = 1,
                    fkStudentTeacherId = 1


                });
            modelBuilder.Entity<Student>()
                .HasData(new Student
                {
                    StudentId = 7,
                    FirstName = "Linus",
                    LastName = "Lundgren",
                    Age = 12,
                    Gender = "M",
                    fkSchoolClassId = 1,
                    fkStudentTeacherId = 1


                });
            modelBuilder.Entity<Student>()
               .HasData(new Student
               {
                   StudentId = 8,
                   FirstName = "Hamphus",
                   LastName = "Stenberg",
                   Age = 12,
                   Gender = "M",
                   fkSchoolClassId = 1,
                   fkStudentTeacherId = 1


               });
            modelBuilder.Entity<Student>()
               .HasData(new Student
               {
                   StudentId = 9,
                   FirstName = "Linda",
                   LastName = "Lundgren",
                   Age = 12,
                   Gender = "F",
                   fkSchoolClassId = 1,
                   fkStudentTeacherId = 1


               });
            modelBuilder.Entity<Student>()
               .HasData(new Student
               {
                   StudentId = 10,
                   FirstName = "Julia",
                   LastName = "Nygren",
                   Age = 12,
                   Gender = "F",
                   fkSchoolClassId = 1,
                   fkStudentTeacherId = 1


               });
            //modelBuilder.Entity<Student>()
            //   .HasData(new Student
            //   {
            //       StudentId = 11,
            //       FirstName = "Klaus",
            //       LastName = "Smith",
            //       Age = 12,
            //       Gender = "M"


            //   });
            //modelBuilder.Entity<Student>()
            //   .HasData(new Student
            //   {
            //       StudentId = 12,
            //       FirstName = "Amanda",
            //       LastName = "Dahlberg",
            //       Age = 12,
            //       Gender = "F"


            //   });
            //modelBuilder.Entity<Student>()
            //   .HasData(new Student
            //   {
            //       StudentId = 13,
            //       FirstName = "Johan",
            //       LastName = "Öberg",
            //       Age = 12,
            //       Gender = "M"


            //   });
            //modelBuilder.Entity<Student>()
            //   .HasData(new Student
            //   {
            //       StudentId = 14,
            //       FirstName = "Reidar",
            //       LastName = "Nilsen",
            //       Age = 12,
            //       Gender = "M"


            //   });
            //modelBuilder.Entity<Student>()
            //    .HasData(new Student
            //    {
            //        StudentId = 15,
            //        FirstName = "Lillemor",
            //        LastName = "Larsson",
            //        Age = 12,
            //        Gender = "F"

            //    });
            //modelBuilder.Entity<Student>()
            //   .HasData(new Student
            //   {
            //       StudentId = 16,
            //       FirstName = "Johanna",
            //       LastName = "Johansson",
            //       Age = 12,
            //       Gender = "F"

            //   });
            //modelBuilder.Entity<Student>()
            //   .HasData(new Student
            //   {
            //       StudentId = 17,
            //       FirstName = "Elijas",
            //       LastName = "Andersson",
            //       Age = 12,
            //       Gender = "M"

            //   });
            //modelBuilder.Entity<Student>()
            //   .HasData(new Student
            //   {
            //       StudentId = 18,
            //       FirstName = "Anas",
            //       LastName = "Alhussain",
            //       Age = 12,
            //       Gender = "M"

            //   });
            //modelBuilder.Entity<Student>()
            //   .HasData(new Student
            //   {
            //       StudentId = 19,
            //       FirstName = "Robin",
            //       LastName = "Hörnkvist",
            //       Age = 12,
            //       Gender = "M"

            //   });
            //modelBuilder.Entity<Student>()
            //    .HasData(new Student
            //    {
            //        StudentId = 20,
            //        FirstName = "Elin",
            //        LastName = "Hägglund",
            //        Age = 12,
            //        Gender = "F"

            //    });
        }

        internal void Add()
        {
            throw new NotImplementedException();
        }
    }
}
