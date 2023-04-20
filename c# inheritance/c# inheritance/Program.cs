using System;

namespace c__inheritance

{  /*
    public class Employee
    {
        public string Firstname;
        public string Lastname;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine(Firstname + " " + Lastname );
        }
    }

    public class FullTimeEmployee : Employee 
    {
        public float yearlySalary;
    }
    public class PartTimeEmployee : Employee
    {
        public float HourlyRate;
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.Firstname = "Pragin";
            FTE.Lastname = "Techeqq ";
            FTE.yearlySalary = 10000;
            
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();  
            PTE.Firstname = "JOHN";
            PTE.Lastname= "DOE";
            PTE.PrintFullName();
        }
    }
    */
    
        public class parentclass
        {
            public parentclass()
            {
                Console.WriteLine("Parentclass constructor called");
            }
        public parentclass(string message) 
        { 
           Console.WriteLine(message);
        }
        }
        public class childclass : parentclass
        {
            public childclass() : base("derived class controlling parent class") 
            {
                Console.WriteLine("Childclass constructor called");
            }
        }

        public class inheritance
        {
            public static void Main()
            {
                childclass CC = new childclass();
            }
        }
    }


