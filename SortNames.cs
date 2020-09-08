using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class SortNames
    {
       
        public static void NameSort(string[] s)
        {
            int pos = 1;
            Console.WriteLine(s[pos]);
            while (pos < s.Length)
            {
                if (String.Compare(s[pos], s[pos - 1], StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    
                    pos++;
                }
                else
                {
                    string temp = s[pos];
                    s[pos] = s[pos - 1];
                    s[pos - 1] = temp;
                    if (pos > 1)
                        pos--;
                }
            }
        }
    }
}
