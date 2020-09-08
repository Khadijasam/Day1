using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {

        //REMOVING SPACE


        //public static void Main(string[] args)
        //{
        //    char[] str = "it      will     take a   ll th   e  wh   ite    spaces".ToCharArray();
        //    int i=SqueezeWhitespaces.removeSpaces(str);
        //    Console.WriteLine(String.Join("" , str).Substring(0, i));
        //    Console.Read();
        //}

    //SORTING USING BUILT-IN 

        //public static void Main(String[] args)
        //{
        //    Console.WriteLine("Please enter a random word of your choice : ");
        //    string letter1 = Console.ReadLine();

        //    Console.WriteLine("Please enter another word of your choice : ");
        //    string letter2 = Console.ReadLine();

        //    string[] words = new string[] { letter1, letter2 }; 
        //    Array.Sort(words);
        //    foreach (string word in words)
        //    {
        //        Console.WriteLine(word);                
        //    }
        //    Console.ReadLine();
        //}

       //SORTING WITHOUT USING BUILT-IN

        public static void Main(String[] args)
        {
            string[] names = { "ziya", "aasha", "akash", "yumna","shiya","barthi" };
            SortNames.NameSort(names);
            foreach (string name in names)
                Console.WriteLine(name);
            Console.Read();
        }

    }
}