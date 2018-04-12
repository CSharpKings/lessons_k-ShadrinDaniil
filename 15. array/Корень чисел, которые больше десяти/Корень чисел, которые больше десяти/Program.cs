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
            double[] numbers = {10, 40, 3, 0, 20000, 6};
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 10)
                { 
                    numbers[i] = Math.Sqrt(numbers[i]);
                }
            Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();
        }
    }
}
