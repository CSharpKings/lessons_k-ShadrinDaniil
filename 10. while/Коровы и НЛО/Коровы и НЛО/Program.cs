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
            int UFO = 300;
            int quantity = 0; 
           
           
            while (true)
            {
                Console.WriteLine("Введи массу коровы");
                int mass = int.Parse(Console.ReadLine());
                UFO = UFO - mass;
                Console.WriteLine(UFO);
                
             
                if (UFO < 0)
                {
                    Console.WriteLine("Отсек для коров заполнен, взлетаем! Вот кол-во коров - " + quantity);
                    Console.ReadLine();
                }


                else
                {
                    quantity = quantity + 1;
                    
                   
                }
               
            }
        }
    }
}
