using System.Collections;
using static c__advanced_assignment2.AllFunctions;

namespace c__advanced_assignment2
{
    internal class Program
    {

 
        static void Main(string[] args)
        {
            #region ex-9
            Queue<object> queue = new Queue<object>();

            queue.Enqueue(1);
            queue.Enqueue("Apple");
            queue.Enqueue(5.28);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            #endregion


            // ----------------- Ex 1: Bubble Sort -----------------
            int[] arr1 = { 5, 1, 4, 2, 8 };
            BubbleSort(arr1);
            Console.WriteLine("Ex1 - BubbleSort: " + string.Join(", ", arr1));

            // ----------------- Ex 2: Reverse ArrayList -----------------
            ArrayList arrList = new ArrayList() { 1, 2, 3, 4, 5 };
            ReverseArray(arrList);
            Console.Write("Ex2 - ReverseArray: ");
            foreach (var item in arrList) Console.Write(item + " ");
            Console.WriteLine();

            // ----------------- Ex 3: Greater than Queries -----------------
            int[] nums = { 1, 3, 5, 7 };
            int[] queries = { 4, 6 };
            Console.WriteLine("Ex3 - GreaterThanQ:");
            greaterthanq(nums, queries);

            // ----------------- Ex 4: Palindrome -----------------
            List<int> palList = new List<int>() { 1, 2, 3, 2, 1 };
            Console.Write("Ex4 - Palindrome: ");
            Palindrome(palList);

            // ----------------- Ex 5: Reverse Queue -----------------
            Queue<int> q1 = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });
            ReverseQueue(q1);
            Console.WriteLine("Ex5 - ReverseQueue: " + string.Join(", ", q1));

            // ----------------- Ex 6: Balanced Parentheses -----------------
            Console.Write("Ex6 - IsBalanced: ");
           IsBalanced("{[()]}"); // Balanced

            // ----------------- Ex 7: Remove Duplicates -----------------
            int[] arr2 = { 1, 2, 2, 3, 3, 4 };
            RemoveDuplicate(ref arr2);
            Console.WriteLine("Ex7 - RemoveDuplicate: " + string.Join(", ", arr2));

            // ----------------- Ex 8: Remove Odd Numbers -----------------
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            RemoveOdd(list1);
            Console.WriteLine("Ex8 - RemoveOdd: " + string.Join(", ", list1));

            // ----------------- Ex 10: Search in Stack -----------------
            Stack<int> stack = new Stack<int>(new int[] { 10, 20, 30, 40 });
            Console.Write("Ex10 - SearchStack: ");
            SearchStack(stack, 30);

            // ----------------- Ex 11: Array Intersection -----------------
            int[] arr3 = { 1, 2, 2, 3, 4 };
            int[] arr4 = { 2, 2, 4, 5 };
            Console.Write("Ex11 - ArrayIntersection: ");
            ArrayIntersection(arr3, arr4);
            Console.WriteLine();

            // ----------------- Ex 12: Subarray with Sum -----------------
            ArrayList arrList2 = new ArrayList() { 1, 2, 3, 7, 5 };
            Console.Write("Ex12 - FindSubArray: ");
            FindSubArray(arrList2, 12);
            Console.WriteLine();

            // ----------------- Ex 13: Reverse First K elements in Queue -----------------
            Queue<int> q2 = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });
            ReverseFirstK(q2, 3);
            Console.WriteLine("Ex13 - ReverseFirstK: " + string.Join(", ", q2));

        }
    }
}
