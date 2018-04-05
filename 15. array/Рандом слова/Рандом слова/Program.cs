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
            string[] subjects = { "Ибрагим", "Петух", "Малыш", "окурок", "интеллигент", "Ёж" };
            string[] adverbs = { "важно", "надувшись" , "жестко", "утонченно", "грустно", "быстро", "плохо"};
            string[] verbs = { "вейпит", "покупает" , "скатился", "ест", "пахнет", "грабит"};
            Random rand = new Random();
            for (int i = 0; i <= 10; i++)
            {
                int i1 = rand.Next(subjects.Length);
                int i2 = rand.Next(adverbs.Length);
                int i3 = rand.Next(verbs.Length);
                Console.WriteLine(subjects[i1] + " " + adverbs[i2] + " " + verbs[i3]);
            }
            Console.ReadLine();


        }
    }
}
