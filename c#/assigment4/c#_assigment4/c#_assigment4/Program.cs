namespace c__assigment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ex-1
            //int [] arr = { 1, 2, 3 ,4,5 };
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++) {
            //    sum += arr[i];
            //        }
            //Console.WriteLine(sum);
            #endregion

            #region ex-2
            //int[] arr1 = { 1, 2, 4, 5, 6 };
            //int[] arr2 = { 10,221, 123, 234,111, 344 };
            //int[] arr3 = new int[arr1.Length + arr2.Length];
            //arr1.CopyTo(arr3, 0);
            //arr2.CopyTo(arr3, arr1.Length); 
            //Array.Sort(arr3);
            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    Console.WriteLine(arr3[i]);
            //}
            #endregion

            #region ex-3
            //int[] arr = { 1, 2, 2, 3, 1, 4, 2 };
            //Dictionary<int, int> frequency = new Dictionary<int, int>();

            #endregion

            #region ex-12?
            //int[] arr = { 1, 2, 3 };
            //int max = int.MinValue;
            //int min = int.MaxValue;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }

            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.WriteLine($"max : {max} min : {min}");
            #endregion

            #region ex-4
            //int[] arr = { 1, 2, 3 };
            //Array.Sort(arr);
            //int max = arr[arr.Length - 1];
            //int max2 = arr[arr.Length - 2];
            //Console.WriteLine($"max : {max} max2 : {max2}");
            #endregion

            #region ex-5

            #endregion

            #region ex-6
            //string sentence = Console.ReadLine();
            //string[] words = sentence.Split(' ');
            //Array.Reverse(words);
            //Console.WriteLine(string.Join(" ", words));
            #endregion

            #region ex-7
            //int rows = int.Parse(Console.ReadLine());
            //int cols = int.Parse(Console.ReadLine());
            //int[,] arr1 = new int[rows, cols];
            //int[,] arr2 = new int[rows, cols];
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        arr1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //    for (int j = 0; j < cols; j++)
            //        arr2[i, j] = arr1[i, j];

            //Console.WriteLine("second array");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //        Console.Write(arr2[i, j]);
            //    Console.WriteLine();
            //}
            #endregion

            #region ex-8
            //int[] arr = { 1, 2, 3, 4 };
            //Array.Reverse(arr);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            #endregion

        }
    }
}
