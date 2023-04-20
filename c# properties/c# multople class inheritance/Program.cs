using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__multople_class_inheritance
{
    /*
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A implementation");
        }
    }

    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("b implementations");
        }
    }
    class C : A
    {
        public override void Print()
        {
            Console.WriteLine("c implementations");
        }
    }
    class D : B, C
    {
        
    }

    class Program
    {
        public static void Main()
        {
            D d = new D();
            d.Print();
        }
    }
    */

    /*


    //  USING INTERFACE  :  C#, a class can only inherit from a single base class, which is known as single inheritance.
    interface IAnimal
    {
        void Move();
    }

    interface IBird
    {
        void Fly();
    }

    class Sparrow : IAnimal, IBird
    {
        public void Move()
        {
            Console.WriteLine("Sparrow can move.");
        }

        public void Fly()
        {
            Console.WriteLine("Sparrow can fly.");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Sparrow s = new Sparrow();
            s.Move();
            s.Fly();
        }
    }  */


interface IA
    {
        void AMethod();
    }
    class A : IA
    {
        public void AMethod() 
        {
            Console.WriteLine("A");
        }
    }
    interface IB
    {
        void BMethod();
    }
    class B : IB
    {
        public void BMethod()
        {
            Console.WriteLine("B");
        }
    }
    
   /* class AB : A , B
    {
   CLASS AB CANNOT HAVE MULTIPLE BASE CLASSES A & B
    }*/
   class  AB: IA, IB
    {
        A a = new A();
        B b = new B();
        public void AMethod() 
        {
            a.AMethod();
            //Console.WriteLine("A");
        }
        public void BMethod()
        {
            b.BMethod();
           // Console.WriteLine("B");
        }
    }
    class Program
    {
        public static void Main()
        {
            AB ab = new AB();
            ab.AMethod();
            ab.BMethod();
        }
    }

}
