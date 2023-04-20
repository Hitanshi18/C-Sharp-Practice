using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__If_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int y = 18;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }

            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            int time1 = 22;
            if (time1 < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time1 < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            //ternory operator
            int t = 20;
            string result = (t < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);
        }
    }
}
