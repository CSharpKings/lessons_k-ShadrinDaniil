﻿using System;
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
            if (age < 150)
            {
                Console.WriteLine("В АТАКУ!!!");
            }
            else  if (health < 50) 
            {
                Console.WriteLine("В АТАКУ!!!");
            }
            if (age >= 150){
                if (health >= 50){ 
                    Console.WriteLine("Не надо... помрешь...");
                }
            }
            Console.ReadLine();
               
            
        }
    }
}
