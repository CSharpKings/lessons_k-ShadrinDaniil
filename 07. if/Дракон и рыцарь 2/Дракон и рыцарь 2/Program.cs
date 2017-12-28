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
             Console.WriteLine("Введите возраст дракона");
             int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите здоровье дракона");
            int health = int.Parse(Console.ReadLine());

            if (age < 150 || health < 50)
            {
                Console.WriteLine("В АТАКУ!!!");
            }
            else
            {
                Console.WriteLine("Не надо... помрешь...");
            }
            Console.ReadLine();
        }
    }
}
