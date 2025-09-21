using EntityFramework_assignment_3.Context;
using EntityFramework_assignment_3.Data;
using EntityFramework_assignment_3.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyContext context = new CompanyContext();

            #region dataseeding

            //int depresult = DataSeed.InitializeDeptsData(context);
            //Console.WriteLine(depresult);

            //int empresult = DataSeed.InitializeEmpsData(context);
            //Console.WriteLine(empresult);

            //if (!context.Students.Any())
            //{
            //    var students = new List<Student>
            //    {
            //        new Student { FName = "Ali", LName = "Mostafa", Address = "Cairo", Age = 22, Dep_Id = 10 },
            //        new Student { FName = "Mona", LName = "Hassan", Address = "Alexandria", Age = 21, Dep_Id = 20 }
            //    };
            //    context.Students.AddRange(students);
            //    context.SaveChanges();
            //}


            //if (!context.Courses.Any())
            //{
            //    var courses = new List<Course>
            //    {
            //        new Course { Name = "C# Basics", Description = "Intro to C#", Duration = 40 },
            //        new Course { Name = "Database Design", Description = "Learn SQL", Duration = 30 }
            //    };
            //    context.Courses.AddRange(courses);
            //    context.SaveChanges();
            //}

            //if (!context.Stud_Course.Any())
            //{
            //    var student1 = context.Students.First();
            //    var student2 = context.Students.Skip(1).First();
            //    var course1 = context.Courses.First();
            //    var course2 = context.Courses.Skip(1).First();

            //    var studCourses = new List<Stud_Course>
            //    {
            //        new Stud_Course { Student_ID = student1.ID, Course_ID = course1.ID, Grade = 85 },
            //        new Stud_Course { Student_ID = student1.ID, Course_ID = course2.ID, Grade = 90 },
            //        new Stud_Course { Student_ID = student2.ID, Course_ID = course1.ID, Grade = 78 }
            //    };

            //    context.Stud_Course.AddRange(studCourses);
            //    context.SaveChanges();
            //}

            #endregion

            #region crud

            //// Insert
            //var dept = new Department( "Computer Science");
            //context.Departments.Add(dept);
            //context.SaveChanges();

            //// Select
            //var depts = context.Departments.ToList();
            //foreach (var department in depts)
            //{
            //    Console.WriteLine(department);
            //}

            //// Update
            //var dept = context.Departments.FirstOrDefault(D => D.Id == 40);
            //if (dept != null)
            //{
            //    dept.Name = "pr";  
            //    context.SaveChanges();
            //}

            //// Delete
            //var dept = context.Departments.FirstOrDefault(d => d.Id == 60);
            //if (dept != null)
            //{
            //    context.Departments.Remove(dept);
            //    context.SaveChanges();
            //}

            //// Insert
            //var student = new Student
            //{
            //    FName = "Ali",
            //    LName = "Mostafa",
            //    Address = "Cairo",
            //    Age = 22,
            //    Dep_Id = 40
            //};
            //context.Students.Add(student);
            //context.SaveChanges();

            //// Select
            //var students = context.Students.ToList();
            //students.ForEach(Console.WriteLine);

            //// Update
            //var student = context.Students.FirstOrDefault(s => s.ID == 1);
            //if (student != null)
            //{
            //    student.Address = "Alexandria";
            //    context.SaveChanges();
            //}

            //// Delete
            //var student = context.Students.FirstOrDefault(s => s.ID == 2);
            //if (student != null)
            //{
            //    context.Students.Remove(student);
            //    context.SaveChanges();
            //}


            //--------------------------------------------

            //// Insert
            //var course = new Course
            //{
            //    Name = "Entity Framework Core",
            //    Description = "Learn EF Core step by step",
            //    Duration = 40
            //};
            //context.Courses.Add(course);
            //context.SaveChanges();

            // Select
            //var courses = context.Courses.ToList();
            //courses.ForEach(Console.WriteLine);

            //// Update
            //var course = context.Courses.FirstOrDefault(c => c.ID == 1);
            //if (course != null)
            //{
            //    course.Duration = 50;
            //    context.SaveChanges();
            //}

            //// Delete
            //var course = context.Courses.FirstOrDefault(c => c.ID == 2);
            //if (course != null)
            //{
            //    context.Courses.Remove(course);
            //    context.SaveChanges();
            //}


            //--------------------------------------------

            // Insert 
            //var studCourse = new Stud_Course
            //{
            //    Student_ID = 4,
            //    Course_ID = 3,
            //    Grade = 95
            //};
            //context.Stud_Course.Add(studCourse);
            //context.SaveChanges();

            // Select
            //var studCourses = context.Stud_Course
            //    .Include(sc => sc.Student)
            //    .Include(sc => sc.Course)
            //    .ToList();
            //studCourses.ForEach(Console.WriteLine);

            //// Update
            //var studCourse = context.Stud_Courses.FirstOrDefault(sc => sc.Student_ID == 1 && sc.Course_ID == 1);
            //if (studCourse != null)
            //{
            //    studCourse.Grade = 100;
            //    context.SaveChanges();
            //}

            //// Delete
            //var studCourse = context.Stud_Courses.FirstOrDefault(sc => sc.Student_ID == 1 && sc.Course_ID == 1);
            //if (studCourse != null)
            //{
            //    context.Stud_Courses.Remove(studCourse);
            //    context.SaveChanges();
            //}

            #endregion

            #region eagerloading

            //var empdept = context.Employees.Include(e => e.Department).FirstOrDefault();
            //Console.WriteLine(empdept.Department.Name);

            //var deptemps = context.Departments.Include(d => d.Employees).Where(d => d.Id == 20);

            //foreach (var dept in deptemps)
            //{
            //    Console.WriteLine($"Department: {dept.Id} - {dept.Name}");


            //    foreach (var emp in dept.Employees)
            //    {
            //        Console.WriteLine(emp);
            //    }
            //}

            #endregion

            #region lazyloading

            //var empdept = context.Employees.FirstOrDefault();
            //Console.WriteLine(empdept.Department.Name);


            //var deptemps = context.Departments.Where(d => d.Id == 20);

            //foreach (var dept in deptemps)
            //{
            //    Console.WriteLine($"Department: {dept.Id} - {dept.Name}");

            //    foreach (var emp in dept.Employees)
            //    {
            //        Console.WriteLine(emp);
            //    }
            //}
            #endregion
        }
    }
}
