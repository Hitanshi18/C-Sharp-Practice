using System;

class Program{
   static void Main()
    {
        Program p = new Program();
        p.EvenNumbers(30);

        Program p1=new Program();
        int sum = p1.add(10, 20);
        Console.WriteLine("sum = {0}", sum);
    }

    public int add (int FN, int SN)
    {
        return FN + SN;
    }
    public void EvenNumbers(int target)
    {
        int start = 0;
        while (start <= target)
        {
            Console.WriteLine(start);
            start = start + 2;
        }
    }

    /*  if the methosd is static method
     public static void Main()
    {
        Program.EvenNumbers();
    }
    public static void EvenNumbers()
    {
        int start = 0;
        while (start <= 20)
        {
            Console.WriteLine(start);
            start = start + 2;
        }
    }   */
}
