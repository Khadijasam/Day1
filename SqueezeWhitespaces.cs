using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class SqueezeWhitespaces
    {
       public static int removeSpaces(char[] str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
                if (str[i] != ' ')
                    str[count++] = str[i];
            return count;
        }



    }
}
