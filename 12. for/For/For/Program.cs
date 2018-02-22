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
            int number = 0;
            
            while (number < 9)
            { 
               number = number + 1;
               int product = number * 7;
               
                Console.WriteLine(number +"*"+ 7 +"="+ product );
                

            }
            Console.ReadLine();
        }
    }
}
