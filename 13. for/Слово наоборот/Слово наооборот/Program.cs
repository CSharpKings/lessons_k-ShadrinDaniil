using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ПИШИИИ!");
            string word = Console.ReadLine();
          

            for (int n  = word.Length - 1; n >= 0; n--)
            {
                Console.WriteLine(word[n]);
             
            }
            Console.ReadLine();
        }
    }
}
