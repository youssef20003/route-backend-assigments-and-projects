using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oop_exam2.classes
{
    public class Answer
    {
        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }

        public int AnswerId { get; set; }
        public string AnswerText { get; set; }


        public override string ToString()
        {
            return $"{AnswerId}. {AnswerText}";
        }
    }
}
