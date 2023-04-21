using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }


            //do-while
            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j < 5);


            //for loop
            for (int k = 0; k <= 10; k = k + 2)
            {
                Console.WriteLine(k);
            }

            //inner/outer
            for (int m = 1; m <= 2; ++m)
            {
                Console.WriteLine("Outer: " + m);  // Executes 2 times

                // Inner loop
                for (int n = 1; n <= 3; n++)
                {
                    Console.WriteLine(" Inner: " + n); // Executes 6 times (2 * 3)
                }
            }

            //foreach
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string c in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
