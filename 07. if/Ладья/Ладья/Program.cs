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
            Console.WriteLine("Введите координаты 1 точки");
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты 2 точки");
            int X2 = int.Parse(Console.ReadLine());
            int Y2 = int.Parse(Console.ReadLine());
            if (X == X2 || Y == Y2)
            {
                Console.WriteLine("Yes");
            }
            else {
                Console.WriteLine("No");
            }
            Console.ReadLine();




        }
    }
}
