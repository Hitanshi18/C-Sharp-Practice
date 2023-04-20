using System;

class Program
{
    public static void Main()
    {
        // Declare and initialize a 2D integer array with 3 rows and 4 columns
        int[,] matrix = new int[3, 4] { { 1, 2, 3, 4 },
                                       { 5, 6, 7, 8 },
                                       { 9, 10, 11, 12 } };

        // Access and print the elements of the 2D array
        Console.WriteLine("2D Array elements:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Update the value of an array element
        matrix[1, 2] = 77;
        Console.WriteLine("2D Array elements after update:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Declare and initialize a 3D float array with dimensions 2x3x4
        float[,,] tensor = new float[2, 3, 4] {
            {
                { 1.1f, 1.2f, 1.3f, 1.4f },
                { 2.1f, 2.2f, 2.3f, 2.4f },
                { 3.1f, 3.2f, 3.3f, 3.4f }
            },
            {
                { 4.1f, 4.2f, 4.3f, 4.4f },
                { 5.1f, 5.2f, 5.3f, 5.4f },
                { 6.1f, 6.2f, 6.3f, 6.4f }
            }
        };

        // Access and print the elements of the 3D array
        Console.WriteLine("3D Array elements:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Console.Write(tensor[i, j, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}
