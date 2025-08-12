using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oop_exam2.classes
{
    public class TrueFalse : question
    {
        public TrueFalse(string header, string body, int mark) : base(header, body, mark)
        {
            AnswerList.Add(new Answer(1, "True"));
            AnswerList.Add(new Answer(2, "False"));

        }
    }
}
