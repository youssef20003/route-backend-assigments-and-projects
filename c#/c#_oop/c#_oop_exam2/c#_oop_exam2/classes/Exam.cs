using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oop_exam2.classes
{
    public abstract class Exam
    {
        public Exam(int time, int numberofQuestions)
        {
            Time = time;
            NumberofQuestions = numberofQuestions;
            Questions = new List<question>();
        }

        public int Time {  get; set; }
        public int NumberofQuestions { get; set; }
        public List<question> Questions { get; set; }

        public abstract void ShowExam();

        protected void AddQuestionBase(question question)
        {
            Questions.Add(question);
        }
        public abstract void AddQuestion(question question);

        public override string ToString()
        {
            return $"Exam Time: {Time} mins, Questions: {NumberofQuestions}";
        }
    }
}
