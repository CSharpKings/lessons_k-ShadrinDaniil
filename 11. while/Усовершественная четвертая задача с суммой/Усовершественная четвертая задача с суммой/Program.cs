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

            int tries = 0;
            int sum = 0;
            int maximum = 4;
            while (tries < maximum)
            {
                while (tries < maximum)
                {
                    Console.WriteLine("Введи число");
                    int number = int.Parse(Console.ReadLine());
                    sum = sum + number;
                    tries = tries + 1;

                    Console.WriteLine(sum);
                  
                }
                tries = 0;
                sum = 0;
                
            }
                Console.ReadLine();
        }
    }
}
