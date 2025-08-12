using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oop_exam2.classes
{
    public class Subject
    {
        public  int Id {  get; set; }
        public string Name { get; set; }
        public Exam Exam;

        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void CreateExam(string type, int time, int numQuestions)
        {
            if (type.ToLower() == "final")
                Exam = new FinalExam(time, numQuestions);
            else if (type.ToLower() == "practical")
                Exam = new PracicalExam(time, numQuestions);
            else
            {
                throw new ArgumentException("Invalid exam type");
            }
        }

        public override string ToString()
        {
            return $"Subject: {Name} (ID: {Id})\n{Exam}";
        }
    }
}
