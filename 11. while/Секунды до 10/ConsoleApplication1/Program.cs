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

            int seconds = 0;
            while (true)
            {
                Thread.Sleep(100);
                seconds = seconds + 1;
                Console.WriteLine(seconds);
                if (seconds == 10)
                {
                   
                    break;
                }
            }
        }
    }
}
