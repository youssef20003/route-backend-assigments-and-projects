namespace c__advanced_assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Department dept = new Department { DeptID = 1, DeptName = "IT" };
            Club club = new Club { ClubID = 1, ClubName = "Sports" };

            Employee emp1 = new Employee { EmployeeID = 101, BirthDate = new DateTime(1990, 5, 1), VacationStock = 3 };
            dept.AddStaff(emp1);
            club.AddMember(emp1);
            emp1.RequestVacation(DateTime.Now, DateTime.Now.AddDays(5));

            dept.ShowStaff();
            club.ShowMembers();
            Console.WriteLine("----");

            Employee emp2 = new Employee { EmployeeID = 102, BirthDate = new DateTime(1950, 1, 1), VacationStock = 5 };
            dept.AddStaff(emp2);
            club.AddMember(emp2);
            emp2.EndOfYearOperation();

            dept.ShowStaff();
            club.ShowMembers();
            Console.WriteLine("----");

            SalesPerson sp = new SalesPerson { EmployeeID = 103, BirthDate = new DateTime(1985, 7, 1), VacationStock = 0, AchievedTarget = 50 };
            dept.AddStaff(sp);
            club.AddMember(sp);
            sp.CheckTarget(Quota: 100);

            dept.ShowStaff();
            club.ShowMembers();
            Console.WriteLine("----");

            BoardMember bm = new BoardMember { EmployeeID = 104, BirthDate = new DateTime(1940, 1, 1), VacationStock = 0 };
            dept.AddStaff(bm);
            club.AddMember(bm);
            bm.Resign();

            dept.ShowStaff();
            club.ShowMembers();



        }
    }
}
