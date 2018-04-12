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
            int[] numbers = { 10, 25, 60, 0, 72, 3000, 40 };
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 10 == 0)
                    {
                        Console.WriteLine(numbers[i]);
                    }
                }
            Console.ReadLine();
        }
    }
}
