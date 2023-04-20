using System;
using System.Diagnostics.CodeAnalysis;

class Program
{

    /*
    //pass by value
   public static void Main()
    {
        int i = 0;
        SimpleMethod(i);
        Console.WriteLine(i);
    }
    public static void SimpleMethod(int j)
    {
        j = 101;
    } 

    */

    /*

    //pass by reference
    public static void Main()
    {
        int i = 0;
        SimpleMethod(ref i);
        Console.WriteLine(i);
    }
    public static void SimpleMethod(ref int j)
    {
        j = 101;
    }

    */


    /*
    //output parameter
    public static void Main()
    {
        int total = 0;
        int product = 0;
        calculation(10, 20, out total, out product);
        Console.WriteLine("sum = {0} && product ={1}", total, product);
    }
    public static void calculation(int FN, int SN, out int sum, out int product)
    {
        sum = FN + SN;
        product = SN *FN;
    }

    */

    //parameter array
    public static void Main()
    {
        int[] Numbers = new int[3];

        Numbers[0] = 101;
        Numbers[1] = 102;
        Numbers[2] = 103;

        //ParamsMethod();
     // ParamsMethod(Numbers);
     ParamsMethod(1,2,3,4,5);   
    }
    public static void ParamsMethod(params int[] Numbers)
    {
        Console.WriteLine("there are {0} elements", Numbers.Length);

        foreach (int i in Numbers)
        {
            Console.WriteLine(i);
        }
    }
}

