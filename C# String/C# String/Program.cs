using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C__String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello...";
            Console.WriteLine(greeting);

            string greeting1 = "Nice to meet you !";
            Console.WriteLine(greeting + ' ' + greeting1);

            string txt = "abcdefghijklmnopqrstuvwxyz";
            Console.WriteLine("The length of the txt string is" + txt.Length);

            string txt1 = "Hello world";
            Console.WriteLine(txt1.ToLower());
            Console.WriteLine(txt1.ToUpper());

            // string concatenation

            string firstnname = "john";
            string lastname = "doe";
            string name = firstnname + ' ' + lastname;
            //  string name = string.Concat(firstnname, lastname);
            Console.WriteLine(name);

            //adding numbers and strings
            int a =10;
            int b = 20;
            int c = a + b;
            Console.WriteLine(c);

           /* int m = "10";
            int n = "20";
            int p = m + n;
            Console.WriteLine(p);  */

            // string interpolation

            string fname = "john";
            string lname = "doe";
            string name1 = $"My full name is : {fname} {lname}";
            Console.WriteLine(name1);

            //access string

            string mystring = "Hey..";
            Console.WriteLine(mystring[0]);
            Console.WriteLine(mystring.IndexOf("y"));

            string nam = "John Doe";

            int charPos = nam.IndexOf("D");
            string lastname1 = nam.Substring(charPos);
            Console.WriteLine(lastname1);


            // special characters

            string txt3 = "We are the so-called \"vikings\" from the north.";
            Console.WriteLine(txt3);

            string txt4 = "It\'s alright..";
            Console.WriteLine(txt4);

        }
  
    }
}
