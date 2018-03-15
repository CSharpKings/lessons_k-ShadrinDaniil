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
            Console.WriteLine("Введи слово");
            string word = Console.ReadLine();
            
            int Last = word.Length - 1;
            if (word[0] == word[Last])
            {
                Console.WriteLine("Мне нравится");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Мне не нравится");
            }
            Console.ReadLine();
        }

    }
}
