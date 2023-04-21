using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__operator
{
    //Arithmetic Operators:
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;

            int sum = a + b; // Addition
            int difference = a - b; // Subtraction
            int product = a * b; // Multiplication
            int quotient = a / b; // Division
            int remainder = a % b; // Modulus

            Console.WriteLine(sum); // Output: 15
            Console.WriteLine(difference); // Output: 5
            Console.WriteLine(product); // Output: 50
            Console.WriteLine(quotient); // Output: 2
            Console.WriteLine(remainder); // Output: 0


            //comparison operator

            int x = 10;
            int y = 20;

            bool isEqual = x == y; // Equality
            bool isNotEqual = x != y; // Inequality
            bool isGreater = x > y; // Greater than
            bool isLess = x < y; // Less than
            bool isGreaterOrEqual = x >= y; // Greater than or equal to
            bool isLessOrEqual = x <= y; // Less than or equal to

            Console.WriteLine(isEqual); // Output: False
            Console.WriteLine(isNotEqual); // Output: True
            Console.WriteLine(isGreater); // Output: False
            Console.WriteLine(isLess); // Output: True
            Console.WriteLine(isGreaterOrEqual); // Output: False
            Console.WriteLine(isLessOrEqual); // Output: True


            //logical operator

            bool p = true;
            bool q = false;

            bool andResult = p && q; // Logical AND
            bool orResult = p || q; // Logical OR
            bool notResult = !p; // Logical NOT

            Console.WriteLine(andResult); // Output: False
            Console.WriteLine(orResult); // Output: True
            Console.WriteLine(notResult); // Output: False


            //assignment operator
            int num = 10;

            num += 5; // Addition assignment
            Console.WriteLine(num); // Output: 15

            num -= 3; // Subtraction assignment
            Console.WriteLine(num); // Output: 12

            num *= 2; // Multiplication assignment
            Console.WriteLine(num); // Output: 24

            num /= 4; // Division assignment
            Console.WriteLine(num); // Output: 6

            num %= 3; // Modulus assignment
            Console.WriteLine(num); // Output: 0

        }
    }
}
