using static c__assigment5.Program;

namespace c__assigment5
{
    internal class Program
    {
        public enum  weekdays:byte
        {
            sunday,
            monday,
            tuesday,
            wednesday,
            thusday,
            friday,
            saturday
            
        }
        static void Main(string[] args)
        {
            #region ex-1
            /*
             * passing value type params
             * when you pass by value any changes that happen int the function only haappens in the function 
             * when you passt by ref you pass the ref in the memory so any change happens to the ref in the memory so the oroginal variable
             * ex : swap function needs to be passed by ref bec if we passed by by value it swaps vars in function only
             */
            #endregion

            #region ex-2
            /*
             * passing ref type params
             * when you pass by value a ref type params the change happen in the function happens outside the function becuase the ref type params always points to a memory address
             * when you pass by ref same happens but we can see the change if we tried to swap the array to new array the new memory address only happens in the function
             */
            #endregion

            #region ex-3
            static string calc(int a , int b , bool sum , bool sub ) {
                string result = "";
                if (sum) {
                    result += $" sum = {a + b}\n";
                }
                if (sub)
                {
                    result += $" sub = {a - b}\n";
                }
                if (!sum && !sub)
                {
                    result = "na";
                }
                    return result;
            }
            #endregion

            #region ex-4
            static int sod (int num)
            {
                int sum = 0;
                while (num != 0) {
                    sum += num % 10;
                    num /= 10;
                }
                return sum;
            }
            #endregion

            #region ex-5
            static bool isprime (int num) { 
            
                if (num <= 1)
                {
                    return false;
                }
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                        return false;
                }
                return true;
            }
            #endregion

            #region ex-6
            static string MinMaxArray(int[] arr)
            { 
                int max = int.MinValue;
                int min = int.MaxValue;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }

                return $"max {max} min {min}";
            }
            #endregion

            #region ex-7
            static int fact(int num) {
                int f =1;
                for (int i = 1; i <= num; i++) {

                    f *= i;
                }
                return f;
            }
            #endregion

            #region ex-8
            static string ChangeChar(ref string str , int num , char ch)
            {
                char[] chars = str.ToCharArray();
                chars[num] = ch;
                str = new string(chars);
                return str;
            }
            #endregion

            #region ex-9
            //foreach (weekdays d in Enum.GetValues(typeof(weekdays)))
            //{
            //    Console.WriteLine(d);
            //}
            #endregion
        }
    }
}
