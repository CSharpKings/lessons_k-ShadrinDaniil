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
            int[] wins = { 4, 2, 6, 1, 9, 3, 4, 0, 2, 19 };
            for (int team = 0; team < wins.Length; team++)
            {
                if (wins[team] < 3)
                {
                    Console.WriteLine(team);
                }
            }
            Console.ReadLine();
        }
    }
}
