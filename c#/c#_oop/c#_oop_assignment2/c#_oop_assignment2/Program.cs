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
            bool swapped;
            employees temp;

            for (int i = 0; i < EmpArr.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < EmpArr.Length - i - 1; j++)
                {
                   
                    if (
                        EmpArr[j].Hd.Year > EmpArr[j + 1].Hd.Year ||
                        (EmpArr[j].Hd.Year == EmpArr[j + 1].Hd.Year && EmpArr[j].Hd.Month > EmpArr[j + 1].Hd.Month) ||
                        (EmpArr[j].Hd.Year == EmpArr[j + 1].Hd.Year && EmpArr[j].Hd.Month == EmpArr[j + 1].Hd.Month && EmpArr[j].Hd.Day > EmpArr[j + 1].Hd.Day)
                       )
                    {
                     
                        temp = EmpArr[j];
                        EmpArr[j] = EmpArr[j + 1];
                        EmpArr[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
            for (int i = 0; i < EmpArr.Length; i++)
            {
                Console.WriteLine(EmpArr[i].ToString());
            }

            #endregion

        }
    }
}
