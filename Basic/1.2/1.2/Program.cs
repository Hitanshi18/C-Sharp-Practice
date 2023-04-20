// operators

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arithmetic operator

            int sum1 = 100 +50;
            int sum2 = sum1 + 250;
            int sum3 = sum2 + sum2;

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);

            //assignment operator

            int x = 10;
            x += 5;
            Console.WriteLine(x);

            //comparison operator

            int y = 5;
            int z = 3;
            Console.WriteLine(y > z); //true

            //logical operator 

            Console.WriteLine(y<z && y>2); //false
            Console.WriteLine(z<y || z>6); //true
            Console.WriteLine(!(y == 5 && y > z)); //false
        }
    }
}
