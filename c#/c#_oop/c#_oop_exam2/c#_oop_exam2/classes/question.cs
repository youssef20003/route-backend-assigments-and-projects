using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oop_exam2.classes
{ 
    public abstract class question : ICloneable , IComparable<question>
    {
        public question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = new List<Answer>();
        }
        public string Header {  get; set; }
        public string Body { get; set; }
        public int Mark {  get; set; }
        public List<Answer> AnswerList { get; set; }
        public Answer RightAnswer { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(question? other)
        {
            if (other == null) return 1;
            return this.Mark.CompareTo(other.Mark);
        }

        public override string ToString()
        {
            string answers = string.Join("\n", AnswerList);

            return $"{Header}: {Body} (Mark: {Mark})\n{answers}";
        }
    }
}
