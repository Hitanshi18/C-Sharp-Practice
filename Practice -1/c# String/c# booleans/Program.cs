using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Booleans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isCSharpFun = true;
            bool isVBFun = true;
            Console.WriteLine(isCSharpFun);
            Console.WriteLine(isVBFun);


            int myage = 21;
            int votingage = 18;
            if (myage > votingage)
            {
                Console.WriteLine("Old enough to vote!");
            }
            else
            {
                Console.WriteLine("Not old enough to vote!");
            }
        }
    }
}