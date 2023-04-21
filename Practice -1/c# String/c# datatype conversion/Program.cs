using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__datatype_conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Explicit Casting:  used when you want to convert a data type to another data type

            double doubleValue = 3.14;
            int intValue = (int)doubleValue; // Explicit casting from double to int

            Console.WriteLine(intValue); // Output: 3 (data loss due to truncation)

            //Implicit Casting:  known as "type coercion," happens automatically when you assign a smaller data type value to a larger data type variable

            /*int intValue = 10;
            double doubleValue = intValue; // Implicit casting from int to double

            Console.WriteLine(doubleValue); // Output: 10 (no data loss)
            */

            // convert method
            string stringValue = "123";
            _ = Convert.ToInt32(stringValue); // Convert string to int

            Console.WriteLine(intValue); // Output: 123


            //parse method :converting strings to other data types

            /*
            string stringValue = "3.14";
            double doubleValue = double.Parse(stringValue); // Parse string to double

            Console.WriteLine(doubleValue); // Output: 3.14
            */

            //to string method
           
            /*
            int intValue = 123;
            string stringValue = intValue.ToString(); // Convert int to string

            Console.WriteLine(stringValue); // Output: "123"
            */
        }
    }
}
