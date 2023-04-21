using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace c__nullable_value
{

    //nullable types allow you to assign a null value to value types, which are normally non-nullable. This can be useful when you want to represent the absence of a value in a variable. 
    internal class Program
    {
        static void Main(string[] args)
        {
            int? nullableInt = null; // Declare a nullable int

            if (nullableInt.HasValue)
            {
                // Access the value of nullableInt if it has a value
                int value = nullableInt.Value;
                Console.WriteLine(value); // This will not be executed as nullableInt is null
            }
            else
            {
                Console.WriteLine("nullableInt is null"); // Output: nullableInt is null
            }

            // Assign a value to nullableInt
            nullableInt = 42;

            if (nullableInt.HasValue)
            {
                int value = nullableInt.Value;
                Console.WriteLine(value); // Output: 42
            }
            else
            {
                Console.WriteLine("nullableInt is null");
            }

            // Use the null conditional operator
            int? anotherNullableInt = null;
            int result = anotherNullableInt?.Value ?? -1;
            Console.WriteLine(result); // Output: -1

            // Use null coalescing operator
            int? yetAnotherNullableInt = null;
            int defaultValue = -1;
            int finalResult = yetAnotherNullableInt ?? defaultValue;
            Console.WriteLine(finalResult); // Output: -1

        }
    }
}
*/