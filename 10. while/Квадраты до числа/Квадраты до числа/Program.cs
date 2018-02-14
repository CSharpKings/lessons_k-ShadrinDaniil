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
            Console.WriteLine("Write number");
            int number = int.Parse(Console.ReadLine());
            int number2 = 0;
            while(true)  
            {
                Thread.Sleep(1000);
                number2 = number2 + 1;

                int square = number2 * number2;
               
                if (number < square)
                {
                    Console.ReadLine();
                    break;
                    
                }
                
                Console.WriteLine(square);   
            } 
  
        }
    }
}



