using EntityFramework_assignment_2.Context;
using EntityFramework_assignment_2.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ItiContext context = new ItiContext();

            #region CRUD


            var dept = new Department { Name = "CS", HiringDate = DateTime.Now, Ins_ID = 1 };
            context.Departments.Add(dept);
            context.SaveChanges();


            var inst = new Instructor
            {
                Name = "Ahmed Ali",
                Salary = 5000,
                Bouns = 500,
                Adress = "Cairo",
                HourRate = 200,
                Dept_ID = dept.ID
            };

            context.Instructors.Add(inst);
            context.SaveChanges();


            var student = new Student { FName = "Youssef", LName = "Mostafa", Address = "Helwan", Age = 20, Dep_Id = dept.ID };
            context.Students.Add(student);
            context.SaveChanges();

            var topic = new Topic { Name = "Databases" };
            context.Topics.Add(topic);
            context.SaveChanges();


            var course = new Course { Name = "SQL Server", Duration = 40, Description = "Intro to SQL", TopicID = topic.ID };
            context.Courses.Add(course);
            context.SaveChanges();

            var studCourse = new Stud_Course { Student_ID = student.ID, Course_ID = course.ID, Grade = 95 };
            context.Stud_Courses.Add(studCourse);
            context.SaveChanges();


            var courseInst = new Course_Inst { Inst_ID = inst.ID, Course_ID = course.ID, evaluate = "Excellent" };
            context.Course_Insts.Add(courseInst);
            context.SaveChanges();



            var students = context.Students.ToList();
            foreach (var s in students)
            {
                Console.WriteLine(s);
            }

            var department = context.Departments.ToList();
            foreach (var d in department)
            {
                Console.WriteLine(d);
            }

            var instractors = context.Instructors.ToList();
            foreach (var ins in instractors)
            {
                Console.WriteLine(ins);
                
            }


            var courses = context.Courses.Include(c => c.Topic).ToList();
            foreach (var c in courses)
                Console.WriteLine($"{c.Name} ({c.Topic.Name})");

            var studentu = context.Students.FirstOrDefault(s => s.FName == "Youssef");
            if (student != null)
            {
                student.Address = "Nasr City"; 
                student.Age = 21;
                context.SaveChanges();
            }

            var courseu = context.Courses.FirstOrDefault(c => c.Name == "SQL Server");
            if (course != null)
            {
                course.Duration = 45; 
                context.SaveChanges();
            }

            var studentd = context.Students.FirstOrDefault(s => s.FName == "Youssef");
            if (student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
            }

            var coursed = context.Courses.FirstOrDefault(c => c.Name == "SQL Server");
            if (course != null)
            {
                context.Courses.Remove(course);
                context.SaveChanges();
            }

            #endregion



        }
    }
}
