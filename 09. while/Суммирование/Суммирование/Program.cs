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
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Введи число");
                int number = int.Parse(Console.ReadLine());
                sum = number + sum;
                Console.WriteLine("Ваша сумма ровна" + sum);

            } 
        }
    }
}
