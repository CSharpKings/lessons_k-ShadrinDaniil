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
            Console.WriteLine("Введи свой рост");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Введи свой вес");
            int weight = int.Parse(Console.ReadLine());

            if (height - 100 == weight){
                Console.WriteLine("У вас отличная фигура");
            }
            if (height - 100 > weight){
                Console.WriteLine("Вам надо набрать вес");
            }
            if (height - 100 < weight)
            {
                Console.WriteLine("Вам надо похудеть");
            }
                Console.ReadLine();
               
        }
    }
}
