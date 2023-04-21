using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Arrays
{
    //used to store and manipulate collections of items ..num, string, custom object
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] car = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(car[0]);


            // Declare and initialize an array of integers
            int[] numbers = new int[5]; // Creates an array with 5 elements, initialized with default values (0 for int)

            // Assign values to array elements
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            // Access array elements
            Console.WriteLine(numbers[0]); // Output: 1
            Console.WriteLine(numbers[2]); // Output: 3

            // Declare and initialize an array of strings
            string[] names = new string[] { "Alice", "Bob", "Charlie", "Dave" }; // Creates an array with 4 elements and initializes them with values

            // Access array elements
            Console.WriteLine(names[1]); // Output: "Bob"

            // Loop through array elements
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            // Output:
            // "Alice"
            // "Bob"
            // "Charlie"
            // "Dave"

            // Multidimensional array
            int[,] matrix = new int[3, 3]; // Creates a 2-dimensional array with 3 rows and 3 columns

            // Assign values to array elements
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[1, 0] = 4;
            matrix[1, 1] = 5;
            matrix[1, 2] = 6;
            matrix[2, 0] = 7;
            matrix[2, 1] = 8;
            matrix[2, 2] = 9;

            // Access array elements
            Console.WriteLine(matrix[0, 1]); // Output: 2
            Console.WriteLine(matrix[2, 2]); // Output: 9

        }

        // Create an array of four elements, and add values later
        // string[] cars = new string[4];

        // Create an array of four elements and add values right away 
        // string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

        // Create an array of four elements without specifying the size 
        //string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

        // Create an array of four elements, omitting the new keyword, and without specifying the size
        //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

        //loop throw an aray

        /* string fruits = { "strawberry","cherry","banana","apple","grapes"};
         for(int a=0; a< fruits.length; a++){
             console.writeline(fruits[a]);  */


    }
}
