using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__explicit_interface
{

    /*
   interface i1
    {
        void Interfacemethod();
    }
    interface i2
    {
        void Interfacemethod();
    }
    public class Program : i1 , i2
    {
          void i1.Interfacemethod()
        {
            Console.WriteLine("i1 interface method");
        }
        void i2.Interfacemethod()
        {
            Console.WriteLine("i2 interface method");
        }

        public static void Main()
        {
            Program P = new Program();
           // P.Interfacemethod();
           ((i1)(P)).Interfacemethod();
           ((i2)(P)).Interfacemethod();
        }
    }  */

    public interface IExampleInterface1
    {
        void Foo();
    }

    public interface IExampleInterface2
    {
        void Foo();
    }

    public class ExampleClass : IExampleInterface1, IExampleInterface2
    {
        void IExampleInterface1.Foo()
        {
            Console.WriteLine("foo method called");
        }

        void IExampleInterface2.Foo()
        {
            Console.WriteLine("foo method doesn't called");
        }

        public static void Main()
        {
            ExampleClass e = new ExampleClass();
            ((IExampleInterface1)e).Foo();
            ((IExampleInterface2)e).Foo();
        }
    }

}
