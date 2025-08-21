using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace c__advanced_assignment2
{
    public static class AllFunctions
    {
        #region ex-1
        //O(n) is the best case time when the array is already sorted (no swap)
        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool swap = false;

                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Helper.swap(ref arr[j], ref arr[j + 1]);
                        swap = true;
                    }
                }
                if (!swap)
                {
                    break;
                }

            }
        }


        #endregion

        #region ex-2

        public static void ReverseArray(ArrayList arr)
        {

            int start = 0;
            int end = arr.Count - 1;
            while (start < end)
            {
                object temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
            }

        }

        #endregion

        #region ex-3

        public static void greaterthanq(int[] arr, int[] queries)
        {

            Array.Sort(arr);
            foreach (int q in queries)
            {
                int x = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (q > arr[i])
                    {
                        x++;
                    }

                }
                Console.WriteLine(x);
            }


        }

        #endregion

        #region ex-4

        public static void Palindrome(List<int> List)
        {
            int start = 0;
            int end = List.Count - 1;

            while (start < end)
            {

                if (List[start] != List[end])
                {
                    Console.WriteLine("No");
                    return;

                }


                start++;
                end--;

            }

            Console.WriteLine("Yes");
        }
        #endregion

        #region ex-5

        public static void ReverseQueue<T>(Queue<T> q)
        {

            Stack<T> s = new Stack<T>();

            while (q.Count > 0)
            {

                s.Push(q.Dequeue());
            }
            while (s.Count > 0)
            {
                q.Enqueue(s.Pop());
            }

        }

        #endregion

        #region ex-6

        public static void IsBalanced(string s)
        {
            Stack<char> st = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    st.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (st.Count == 0)
                    {
                        Console.WriteLine("unbalanced");
                        return;
                    }

                    char open = st.Pop();
                    if ((c == ')' && open != '(') ||
                        (c == ']' && open != '[') ||
                        (c == '}' && open != '{'))
                    {
                        Console.WriteLine("unbalanced");
                        return;
                    }
                }
            }
            if (st.Count == 0)
            {
                Console.WriteLine("Balanced");
            }
            else
            {
                Console.WriteLine("Unbalanced");
            }

        }

        #endregion

        #region ex-7

        public static void RemoveDuplicate(ref int[] arr)
        {
            arr = arr.Distinct().ToArray();

        }

        #endregion

        #region ex-8

        public static void RemoveOdd(List<int> list)
        {
            list.RemoveAll(x => x % 2 != 0);
        }

        #endregion

        #region ex-10

        public static void SearchStack(Stack<int> Q, int T)
        {
            int count = 0;

            foreach (int x in Q)
            {
                if (x == T)
                {
                    Console.WriteLine($"Target was found successfully and the count = {count}");
                    return;
                }

                count++;

            }

            Console.WriteLine("Target was not found");
        }

        #endregion

        #region ex-11

        public static void ArrayIntersection(int[] arr1, int[] arr2)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();

            List<int> result = new List<int>();

            foreach (int num in arr1)
            {
                if (freq.ContainsKey(num))
                    freq[num]++;
                else
                    freq[num] = 1;
            }

            foreach (int num in arr2)
            {
                if (freq.ContainsKey(num) && freq[num] > 0)
                {
                    result.Add(num);
                    freq[num]--;
                }
            }

            foreach (int num in result)
            {
                Console.Write($" {num} ");
            }


        }

        #endregion

        #region ex-12

        public static void FindSubArray(ArrayList arr, int T)
        {

            int start = 0;
            int currentSum = 0;

            for (int end = 0; end < arr.Count; end++)
            {
                currentSum += (int)arr[end];


                while (currentSum > T && start <= end)
                {
                    currentSum -= (int)arr[start];
                    start++;
                }


                if (currentSum == T)
                {

                    for (int i = start; i <= end; i++)
                    {
                        Console.Write(arr[i] + " ");
                    }

                    return;
                }
            }

            Console.WriteLine("No subarray");
        }



        #endregion

        #region ex-13

        public static void ReverseFirstK<T>(Queue<T> q, int k)
        {
            if (k > q.Count || k <= 0) return;

            Stack<T> st = new Stack<T>();

            for (int i = 0; i < k; i++)
            {
                st.Push(q.Dequeue());
            }

            while (st.Count > 0)
            {
                q.Enqueue(st.Pop());
            }

            int remaining = q.Count - k;
            for (int i = 0; i < remaining; i++)
            {
                q.Enqueue(q.Dequeue());
            }
        }


        #endregion

    }
}
