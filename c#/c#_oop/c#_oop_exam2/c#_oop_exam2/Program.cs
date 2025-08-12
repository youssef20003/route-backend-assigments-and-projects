using c__oop_exam2.classes;

namespace c__oop_exam2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * hola yassin
             * 
             * this is the full project i think 
             * the class diagram in the solution file as a(draw.io and png)
             * 
             * i added validations to make sure final exam accepts mcq and true or false and practical only mcq
             * i also added user input exam 
             * 
             * steps of code implemented exam
             * 1st : create subject
             * 2nd : create exam subject and ref to subject exam
             * 3rd : make questions and add answers
             * 4th : show exam
             */

            #region for final exam
            //Subject subject = new Subject(1, "Mathematics");

            //subject.CreateExam("final", 15, 2);

            //Exam exam = subject.Exam;


            //MCQ mcq1 = new MCQ("Q1", "What is 2 + 2?", 5);
            //mcq1.AnswerList.Add(new Answer(1, "3"));
            //mcq1.AnswerList.Add(new Answer(2, "4"));
            //mcq1.AnswerList.Add(new Answer(3, "5"));
            //mcq1.RightAnswer = mcq1.AnswerList[1];
            //exam.AddQuestion(mcq1);


            //TrueFalse tf1 = new TrueFalse("Q2", "The Earth is flat.", 5);
            //tf1.RightAnswer = tf1.AnswerList[1];
            //exam.AddQuestion(tf1);

            //exam.ShowExam();

            #endregion

            #region for practical exam 
            //Subject subject = new Subject(1, "Mathematics");

            //subject.CreateExam("practical", 15, 2);

            //Exam exam = subject.Exam;


            //MCQ mcq1 = new MCQ("Q1", "What is 2 + 2?", 5);
            //mcq1.AnswerList.Add(new Answer(1, "3"));
            //mcq1.AnswerList.Add(new Answer(2, "4"));
            //mcq1.AnswerList.Add(new Answer(3, "5"));
            //mcq1.RightAnswer = mcq1.AnswerList[1];
            //exam.AddQuestion(mcq1);


            //exam.ShowExam();

            #endregion

            #region user input exam

            //Console.Write("What is the subject? ");
            //string subjectName = Console.ReadLine();

            //Console.Write("ID? ");
            //int subjectId = int.Parse(Console.ReadLine());

            //Subject subject = new Subject(subjectId, subjectName);

            //Console.Write("Enter exam type Final/Practical");
            //string examType = Console.ReadLine();

            //Console.Write("Exam time minutes");
            //int time = int.Parse(Console.ReadLine());

            //Console.Write("Number of questions ");
            //int numQuestions = int.Parse(Console.ReadLine());


            //subject.CreateExam(examType, time, numQuestions);

            //for (int i = 0; i < numQuestions; i++)
            //{
            //    Console.WriteLine($"Question {i + 1}");

            //    Console.Write("Header: ");
            //    string header = Console.ReadLine();

            //    Console.Write("Body: ");
            //    string body = Console.ReadLine();

            //    Console.Write("Mark: ");
            //    int mark = int.Parse(Console.ReadLine());

            //    question q = null;

            //    if (examType.ToLower() == "final")
            //    {
            //        Console.Write("Type MCQ/TF");
            //        string qType = Console.ReadLine();

            //        if (qType.ToLower() == "mcq")
            //        {
            //            q = new MCQ(header, body, mark);
            //            Console.Write("How many answers? ");
            //            int ansCount = int.Parse(Console.ReadLine());

            //            for (int a = 1; a <= ansCount; a++)
            //            {
            //                Console.Write($"Answer {a}: ");
            //                q.AnswerList.Add(new Answer(a, Console.ReadLine()));
            //            }
            //        }

            //        else if(qType.ToLower()=="tf")
            //        {
            //            q = new TrueFalse(header, body, mark);
            //        }


            //    }

            //    else if (examType.ToLower() == "practical")
            //    {

            //        q = new MCQ(header, body, mark);
            //        Console.Write("How many answers? ");
            //        int ansCount = int.Parse(Console.ReadLine());

            //        for (int a = 1; a <= ansCount; a++)
            //        {
            //            Console.Write($"Answer {a}: ");
            //            q.AnswerList.Add(new Answer(a, Console.ReadLine()));
            //        }
            //    }

            //    Console.Write("Enter correct answer number: ");
            //    int rightAnsNum = int.Parse(Console.ReadLine());
            //    q.RightAnswer = q.AnswerList[rightAnsNum - 1];

            //    subject.Exam.AddQuestion(q);


            //}

            //Console.WriteLine("Starting Exam");
            //subject.Exam.ShowExam();

            #endregion





        }
    }
}
