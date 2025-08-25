using System.Collections;
using System.Text.RegularExpressions;

namespace c__advanced_assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ex-1
            //int[] arr = { 1, 2, 2, 4, 5, 1, 2, 3, 5, 6 };
            //Hashtable freq = new Hashtable();

            //foreach (int i in arr)
            //{
            //    if (freq.ContainsKey(i))
            //    {
            //        freq[i] = (int)freq[i] + 1;

            //    }
            //    else
            //    {
            //        freq[i] = 1;
            //    }
            //}

            //foreach (DictionaryEntry entry in freq)
            //{
            //    Console.WriteLine($"{entry.Key} : {entry.Value}");
            //}
            #endregion

            #region ex-2

            //Hashtable ht = new Hashtable()
            //{
            //    {"a", 5},
            //    {"b", 10},
            //    {"c", 7}
            //};

            //string maxKey = "";
            //int maxVal = int.MinValue;


            //foreach (DictionaryEntry entry in ht)
            //{
            //    if ((int)entry.Value > maxVal)
            //    {
            //        maxVal = (int)entry.Value;
            //        maxKey = entry.Key.ToString();
            //    }
            //}

            //Console.WriteLine($"highest value = {maxKey}");

            #endregion

            #region ex-3

            //Hashtable ht = new Hashtable()
            //{
            //      {"key1", "apple"},
            //      {"key2", "banana"},
            //      {"key3", "apple"}
            //};

            //string target = "apple";
            //bool found = false;

            //foreach (DictionaryEntry entry in ht)
            //{
            //    if (entry.Value.ToString() == target)
            //    {
            //        Console.WriteLine(entry.Key);
            //        found = true;
            //    }
            //}

            //if (!found) Console.WriteLine("Key not found");
            #endregion

            #region ex-4

            //string[] s = { "eat", "tea", "tan", "ate", "nat", "bat" };
            //Dictionary<string, List<string>> group = new Dictionary<string, List<string>>();

            //foreach (var word in s)
            //{
            //    char[] chars = word.ToCharArray();
            //    Array.Sort(chars);

            //    string key = new string(chars);

            //    if (!group.ContainsKey(key))
            //    {
            //        group[key] = new List<string>();
            //    }

            //        group[key].Add(word);


            //}
            //foreach (var kvp in group)
            //{
            //    Console.WriteLine($"{kvp.Key} => {string.Join(", ", kvp.Value)}");
            //}

            #endregion

            #region ex-5

            //int[] arr = { 1, 2, 2, 3, 4, 5, 6, 3, 4, };

            //HashSet<int> duplicates = new HashSet<int>();

            //bool Duplicate = false;

            //foreach (int i in arr) {

            //    if (!duplicates.Add(i)) { 

            //        Duplicate = true;
            //        break;
            //    }
            //}

            //Console.WriteLine(Duplicate ? "Duplicates found" : "No duplicates");

            #endregion

            #region ex-6

            //SortedDictionary<int , string> student = new SortedDictionary<int , string>();

            //student.Add(101, "pablo");
            //student.Add(103, "marwan");
            //student.Add(102, "ahmed");

            //student.Remove(103);

            //Console.WriteLine(student[101]);

            #endregion

            #region ex-7

            //SortedList<int , string> employees = new SortedList<int , string>();

            //employees.Add(101, "pablo");
            //employees.Add(103, "marwan");
            //employees.Add(102, "ahmed");

            //employees.Remove(103);

            //foreach (var kv in employees)
            //{
            //    Console.WriteLine($"{kv.Key} → {kv.Value}");
            //}

            #endregion

            #region ex-8

            //int N = 10;
            //int[] nums = { 1, 2, 4, 6, 7, 10 };

            //HashSet<int> setNums = new HashSet<int>(nums);

            //for (int i = 1; i <= N; i++)
            //{
            //    if (!setNums.Contains(i))
            //        Console.WriteLine(i);
            //}

            #endregion

            #region ex-9

            //int[] nums = { 1, 2, 2, 3, 4, 4, 5 };
            //HashSet<int> unique = new HashSet<int>(nums);

            //foreach (var num in unique)
            //    Console.WriteLine(num);

            #endregion

            #region ex-10

            //Hashtable ht = new Hashtable()
            //{
            //    {"a", 1},
            //    {"b", 2},
            //    {"c", 3}
            //};

            //Hashtable swapped = new Hashtable();

            //foreach (DictionaryEntry entry in ht)
            //    swapped[entry.Value] = entry.Key;

            //foreach (DictionaryEntry entry in swapped)
            //    Console.WriteLine($"{entry.Key} → {entry.Value}");

            #endregion

            #region ex-11

            //HashSet<int> set1 = new HashSet<int>() { 1, 2, 3 };
            //HashSet<int> set2 = new HashSet<int>() { 3, 4, 5 };

            //set1.UnionWith(set2);

            //foreach (var num in set1)
            //    Console.WriteLine(num);

            #endregion

            #region ex-12

            //Dictionary<string, int> dict = new Dictionary<string, int>()
            //{
            //   {"apple", 1},
            //    {"animal", 2},
            //    {"airport", 3},
            //   {"ball", 4}
            //};

            //char targetChar = 'a';
            //int count = 0;

            //foreach (var key in dict.Keys)
            //{
            //    if (key.StartsWith(targetChar.ToString()))
            //        count++;
            //}

            #endregion

            #region ex-13

            //SortedSet<int> set = new SortedSet<int>() { 1, 3, 5, 7, 9 };
            //int target = 4;

            //List<int> result = new List<int>();

            //foreach (var num in set)
            //{
            //    if (num > target)
            //        result.Add(num);
            //}


            //Console.WriteLine(string.Join(", ", result));

            #endregion

            #region ex-14

            SortedList<int, int> sl = new SortedList<int, int>()
            {
                 {1, 10}, {2, 15}, {3, 20}, {4, 25}
            };

            foreach (var kv in sl)
            {
                if (kv.Value % 2 == 0)
                    Console.WriteLine(kv.Key);
            }

            #endregion
        }
    }
}
