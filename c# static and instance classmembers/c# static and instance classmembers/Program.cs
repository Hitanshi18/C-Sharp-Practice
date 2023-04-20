using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class circle
{
    float _PI = 3.141F;
    int _Radius;

    public circle (int Radius)
    {
        this._Radius = Radius;
    }
    public float calculateArea()
    {
        return this._Radius* this._PI* this._Radius;
    }
}
    
    
    class Program
{
    public static void Main()
    {
        circle c1 = new circle(5);
        float area = c1.calculateArea();

        Console.WriteLine("area = {0}", area);


        circle c2 = new circle(6);
        float area2 = c2.calculateArea();

        Console.WriteLine("area = {0}", area2);
    }
}
