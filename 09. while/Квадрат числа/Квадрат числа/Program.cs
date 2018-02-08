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
           
            while (true)
            {
                 Console.WriteLine("Введи любое число");
                 int number = int.Parse(Console.ReadLine());
                 Console.WriteLine(number * number);
            }
        }
    }
}
