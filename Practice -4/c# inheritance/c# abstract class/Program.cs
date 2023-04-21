using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Abstract_class
{
    public abstract class customer
    {
        public void Print()
        {
            Console.WriteLine("print ");
        }
        public class Program : customer
        {
            /*public override void Print()
            {
                Console.WriteLine("print method");
            }*/
            public static void Main(string[] args)
            {
                // customer C = new Program();
                //C.Print();
            }
        }
    }
}
