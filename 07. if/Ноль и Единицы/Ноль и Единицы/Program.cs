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
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("-1");
            }
            if (number > 1)
            {
                Console.WriteLine("1");
            }
            if (number == 0)
            {
                Console.WriteLine("0");
            }
            Console.ReadLine();

        }
    }
}
