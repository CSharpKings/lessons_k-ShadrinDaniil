using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            while (true)
            {
                Console.WriteLine("Реши пример!");

                int number1 = rand.Next(30);
                int number2 = rand.Next(30);
                int number3 = rand.Next(30);
                Console.WriteLine(number1 + "+" + number2 + "+" + number3);
                int sum = int.Parse(Console.ReadLine());
                if (sum == number1 + number2 + number3)
                {
                    Console.WriteLine("Правильно");
                    Thread.Sleep(5000);
                    break;
                }

                else {
                    Console.WriteLine("Непрвильно");
                }
                
            }
           
        }
    }
}
