using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__access_modifier
{
    public class Customer
    {
        /* private int _id;
         public int Id
         {
             get
             {
                 return _id;
             }
             set
             {
                 _id = value;
             }
         }   */

        protected int ID;
    }
    public class CorporateCustomer : Customer
    {
        public void PrintID()
        {
            CorporateCustomer CC = new CorporateCustomer();
            CC.ID = 101;
            // base.ID  = CC.ID;  // Base in derived class method refers to base class's instance
            //this.ID = CC.ID;    //
            // if you want to access base class protected members in the derived class either use derived class's object or this or base keyword
        }
    }

    /*
    public class MainClass
    {
        private static void Main()
        {
            Customer C1 = new Customer();
            Console.WriteLine(C1.Id);
            //Console.WriteLine(C1._id);

        }
    }
    */

}

/* internal protected 
 

// File: Assembly1.cs
using System;

internal class MyClass
{
    protected void MyProtectedMethod()
    {
        Console.WriteLine("This is a protected method.");
    }

    internal protected void MyInternalProtectedMethod()
    {
        Console.WriteLine("This is an internal protected method.");
    }
}

// File: Assembly2.cs
using System;

public class MyDerivedClass : MyClass
{
    public void AccessMyInternalProtectedMethod()
    {
        MyInternalProtectedMethod(); // Accessible in a derived class in a different assembly
    }
}

// File: Program.cs
using System;

public class Program
{
    static void Main()
    {
        MyClass obj1 = new MyClass();
        obj1.MyInternalProtectedMethod(); // Accessible within the same assembly

        MyDerivedClass obj2 = new MyDerivedClass();
        obj2.AccessMyInternalProtectedMethod(); // Accessible in a derived class in a different assembly
    }
}
*/