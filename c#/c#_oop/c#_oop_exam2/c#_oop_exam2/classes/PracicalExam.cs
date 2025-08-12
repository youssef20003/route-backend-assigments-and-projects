using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oop_exam2.classes
{
    internal class PracicalExam : Exam
    {
        public PracicalExam(int time, int numberofQuestions) : base(time, numberofQuestions)
        {
        }
        public override void AddQuestion(question Question)
        {
            if (Question is  MCQ)
            {
                AddQuestionBase(Question);
            }
            else
            {
                throw new InvalidOperationException("practical exam only mcq questions");
            }

        }

        public override void ShowExam()
        {
            Console.WriteLine("practical exam");

            int marks = 0;



            foreach (var q in Questions)
            {
                Console.WriteLine(q);

                int choice = int.Parse(Console.ReadLine());

                if (q.RightAnswer != null && q.RightAnswer.AnswerId == choice)
                {
                    marks += q.Mark;

                }
            }
            Console.WriteLine($"mark {marks}");


        }
    }
}
