using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace c__oop_exam2.classes
{
    internal class FinalExam : Exam
    {
        public FinalExam(int time, int numberofQuestions) : base(time, numberofQuestions)
        {
        }

        public override void AddQuestion(question Question)
        {
            if(Question is TrueFalse || Question is MCQ)
            {
                AddQuestionBase(Question);
            }
            else
            {
                throw new InvalidOperationException("Final exam only accepts MCQ or True/False questions");
            }

        }


        public override void ShowExam()
        {
            Console.WriteLine("final exam");

            int marks = 0;

      
            foreach(question q in Questions)
            {
                Console.WriteLine(q);

                int choice = int.Parse(Console.ReadLine());

                if ( q.RightAnswer != null && q.RightAnswer.AnswerId ==choice )
                {
                    marks += q.Mark;

                }
            }
            Console.WriteLine($"mark {marks}");

            
        }

      
    }
}
