using c__oop_assignment4.classes;
using System.Drawing;

namespace c__oop_assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part-1

            //1-b

            //2-a

            //3-b

            //4-b

            //5-d or :

            //6-a

            //7-b

            //8-a

            //9-a

            //10-c

            #endregion

            #region part-2

            #region ex-1

            //Myrectangle rectangle = new Myrectangle(2,4);

            //rectangle.DisplayShapeInfo();

            //Circle circle = new Circle(2);

            //circle.DisplayShapeInfo();

            #endregion

            #region ex-2
            
            BasicAuthenticationService basicAuthenticationService = new BasicAuthenticationService();


            string username = "john";
            string password = "john123";
            string role = "User";

            Console.WriteLine(basicAuthenticationService.AuthenticateUser(username, password)) ;

            Console.WriteLine(basicAuthenticationService.AuthorizeUser(username , role)) ;

            #endregion

            #endregion
        }
    }
}
