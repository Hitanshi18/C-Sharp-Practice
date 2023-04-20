// Define an interface
using System;
/*
public interface IShape
{
    void Draw();    // Method declaration
    double Area { get; }   // Property declaration
}

// Implement the interface in a class
public class Circle : IShape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }

    public double Area
    {
        get { return Math.PI * radius * radius; }
    }
}

public class Rectangle : IShape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public void Draw()
    {
        Console.WriteLine("Drawing a rectangle.");
    }

    public double Area
    {
        get { return width * height; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create objects of classes that implement the IShape interface
        IShape shape1 = new Circle(5);
        IShape shape2 = new Rectangle(10, 20);

        // Call methods and properties defined in the interface
        shape1.Draw();    // Output: Drawing a circle.
        Console.WriteLine($"Area of shape1: {shape1.Area}");    // Output: Area of shape1: 78.5398163397448

        shape2.Draw();    // Output: Drawing a rectangle.
        Console.WriteLine($"Area of shape2: {shape2.Area}");    // Output: Area of shape2: 200
    }
}

*/


/*
interface ICustomer
{
    //int ID; not contain fields
     void Print(); //interface member can't have access modifier they are public bydefault
    /*{
        Console.WriteLine("hello");
    }  interface member can't have implementation or difination they need to only have declaration*/
/* 
} 
interface I2
{
    void I2method();
}
class Customer : ICustomer , I2
{
    public void I2method()
    {
        Console.WriteLine("I2 METHOD");
    }

    public void Print()
    {
        Console.WriteLine("Interface print method");
    }
}
public class Program
{
public static void Main()
    {
        Customer c1 = new Customer();
        c1.Print();
        c1.I2method();
    }
}


*/

interface ICustomer1
{
    void print1();
}
interface ICustomer2 : ICustomer1
{
    void print2();
}
public class Customer : ICustomer2
{
    public void print2()
    {
        Console.WriteLine("print 2");
    }
    public void print1()
    {
        Console.WriteLine("print 1");
    }
}
public class Program1
{
    public static void Main()
    {
        Customer c1= new Customer();
        c1.print1();
        c1.print2();
    }
}