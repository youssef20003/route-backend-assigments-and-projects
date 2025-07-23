using c__oop_assignment2.classes;

namespace c__oop_assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region ex-3

            employees[] EmpArr = new employees[3];

            EmpArr[0] = new employees(1, "ashraf", 6000, new HiringDate(12, 5, 2020), gender.F, securityLevel.DBA);

            EmpArr[1] = new employees(2, "ahmed", 3000, new HiringDate(1, 3, 2021), gender.M, securityLevel.Guest);

            EmpArr[2] = new employees(3, "youssef", 9000, new HiringDate(7, 8, 2019), gender.M, securityLevel.SecurityOfficer);


            #endregion

            #region ex-4
            
            #endregion

        }
    }
}
