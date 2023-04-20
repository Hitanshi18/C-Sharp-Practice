using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__structs
{
    // Define a struct
    struct Point
    {
        public int X;  // Public field
        public int Y;  // Public field

        // Constructor
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Method
        public void Display()
        {
            Console.WriteLine($"X: {X}, Y: {Y}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Point struct
            Point p1 = new Point(10, 20);

            // Access the fields
            p1.X = 30;
            p1.Y = 40;

            // Call a method
            p1.Display();

            // Copying a struct creates a new instance
            Point p2 = p1;
            p2.X = 50;
            p2.Display();

            // Structs do not reference the same memory location
            Console.WriteLine($"p1.X: {p1.X}, p1.Y: {p1.Y}");  // Output: p1.X: 30, p1.Y: 40
            Console.WriteLine($"p2.X: {p2.X}, p2.Y: {p2.Y}");  // Output: p2.X: 50, p2.Y: 40
        }
    }

}
