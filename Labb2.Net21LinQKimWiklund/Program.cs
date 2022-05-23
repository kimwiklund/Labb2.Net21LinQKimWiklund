﻿using Labb2.Net21LinQKimWiklund.Models;
using System;
using System.Linq;

namespace Labb2.Net21LinQKimWiklund
{
    class Program
    {
        static void Main(string[] args)
        {
            LabbDBContext context = new LabbDBContext();

            Console.WriteLine("Select one of the 5 queries (1-5)");
            Console.WriteLine("1 = Hämta alla lärare som undervisar i X.");
            Console.WriteLine("2 = Hämta alla elever med deras lärare, skriv namn.");
            Console.WriteLine("3 = Hämta alla elever som studerar en kurs. Skriv namn och lärare.");
            Console.WriteLine("4 = Editera ett ämmne till ett annat.");
            Console.WriteLine("5 = Uppdatera en elevs lärare i en kurs till en annan lärare.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:

                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Hämta alla lärare som undervisar i X");
                    Console.WriteLine("----------------------------------");

                    var queryTeacher = (from u in context.Teachers
                                        from p in context.Courses
                                        where p.CourseName == "Math" && u.fkCourseId == 1
                                        select new { TeacherName = u.FirstName, CourseName = p.CourseName }).ToList();
                    foreach (var item in queryTeacher)
                    {
                        Console.WriteLine("Teacher: " + item.TeacherName + " Course: " + item.CourseName);
                    }
                    Console.ReadKey();

                    break;

                case 2:

                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Hämta alla elever med deras lärare, skriv namn");
                    Console.WriteLine("----------------------------------");


                    var queryStudentTeacher = (from u in context.Students
                                               from p in context.Teachers
                                                   //where p.fkCourseId == 1
                                               select new { StudentName = u.FirstName, TeacherName = p.FirstName }).Distinct().ToList();
                    foreach (var item in queryStudentTeacher)
                    {
                        Console.WriteLine("Student: " + item.StudentName + " - Teacher: " + item.TeacherName);
                    }

                    Console.ReadKey();

                    break;

                case 3:

                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Hämta alla elever som studerar en kurs. Skriv namn och lärare.");
                    Console.WriteLine("----------------------------------------");

                    var queryCourseStudent = (from u in context.Courses
                                              from p in context.Teachers
                                              from y in context.Students
                                              where p.fkCourseId == 2 && u.CourseName == "Geography"
                                              select new { StudentName = y.FirstName, TeacherName = p.FirstName }).ToList();
                    foreach (var item in queryCourseStudent)
                    {
                        Console.WriteLine("Student: " + item.StudentName + " - Teacher: " + item.TeacherName);
                    }

                    Console.ReadKey();

                    break;

                case 4:

                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Editera ett ämmne till ett annat");
                    Console.WriteLine("----------------------------------------");

                    var queryCourse = (from u in context.Courses
                                       where u.CourseName == "English"
                                       select new { CourseName = "English2" });
                    context.SaveChanges();

                    foreach (var item in queryCourse)
                    {
                        Console.WriteLine("CourseName: " + item.CourseName);
                    }


                    Console.ReadKey();
                    
                    break;

                case 5:

                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Uppdatera en elevs lärare i en kurs till en annan lärare.");
                    Console.WriteLine("----------------------------------------");

                    var queryTeacherChange = (from u in context.Courses
                                              from p in context.Teachers
                                              from y in context.Students
                                              where u.CourseName == "Math" && p.FirstName == "Bengt" && p.TeacherId == 1 && y.StudentId == 1
                                              select new { CourseName = u.CourseName, FirstName = "Sara", TeacherId = 2, StudentId = y.StudentId });
                    context.SaveChanges();
                    foreach (var item in queryTeacherChange)
                    {
                        Console.WriteLine("CourseName: " + item.CourseName + " Teacher: " + item.FirstName);
                    }


                    Console.ReadKey();

                    break;

                case 0:
                    

                    return;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }

          
            

           

            

            



            //var teacher = context.Teachers.
            //    Join(context.Courses,
            //    teach => teach.TeacherId,
            //    cour => cour.TeacherId,
            //    (teachName, courName) => new
            //    {
            //        tName = teachName,
            //        cName = courName
            //    }).Where(x => x.cName.CourseName == "Math").Distinct().ToList();


            //foreach (var item in teacher)
            //{
            //    Console.WriteLine(item.tName.FirstName + " " + item.cName.CourseName);
            //}
        }
    }
}
