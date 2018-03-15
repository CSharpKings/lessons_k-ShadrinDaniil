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
            Console.WriteLine("ПИШИ!");
            string word = Console.ReadLine();
           
            int sum = 0;
            for (int n = 0; n < word.Length; n++)
            {
                if (word[n] == 'ж')
                {
                    sum = sum + 1;
                }

            }
              Console.WriteLine(sum);
              Console.ReadLine();
        }
    }
}
