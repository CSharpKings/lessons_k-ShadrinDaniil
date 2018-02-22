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
            int rouble = 56;
           
            for (int dollar = 1; dollar <= 20; dollar++)
            {
                 int cash =  dollar * rouble;
                Console.WriteLine(dollar +"="+ cash );
                 
            }
            Console.ReadLine();
        }
    }
}
