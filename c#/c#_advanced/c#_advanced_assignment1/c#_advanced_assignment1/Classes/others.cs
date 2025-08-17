using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__advanced_assignment1.Classes
{
    internal class others
    {
        #region ex-2
        public static List<int> evennumbers(List<int> list)
        {
            return list.Where(n => n % 2 == 0).ToList();
        }
        #endregion

        #region ex-4

        public static int uniqenumber(string s)
        {
            Dictionary<char , int> freq = new Dictionary<char , int>();

            foreach (char c in s)
            {

                if (freq.ContainsKey(c))
                {
                    freq[c]++;
                }
                else
                {
                    freq[c] = 1;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (freq[s[i]] == 1)
                    return i;
            }

            return -1;
        }

        #endregion


    }
}
