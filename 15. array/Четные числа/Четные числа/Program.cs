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
           int[] integer = {7, 4, 198, 199998, 0, 1, 3, 5, 9, 20};
           for (int i = 0; i < 10; i++)
           {
               if (integer[i] % 2 == 0)
               {
                   Console.WriteLine(integer[i]);
               }
              
           }
                Console.ReadLine();
        }
    }
}
