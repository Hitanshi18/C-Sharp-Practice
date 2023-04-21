using c__delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__delegates
{
    /*
    // Define a delegate type with a specific signature
    delegate int MathOperation(int a, int b);

    class Calculator
    {
        // Define methods that match the signature of the delegate
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main()
        {
            // Create an instance of the Calculator class
            Calculator calculator = new Calculator();

            // Create delegates that point to the Add and Subtract methods
            MathOperation addDelegate = calculator.Add;
            MathOperation subtractDelegate = calculator.Subtract;

            // Use the delegates to invoke the methods
            int result1 = addDelegate(5, 3); // Invokes the Add method
            int result2 = subtractDelegate(10, 5); // Invokes the Subtract method

            Console.WriteLine("Result of Add: " + result1); // Output: Result of Add: 8
            Console.WriteLine("Result of Subtract: " + result2); // Output: Result of Subtract: 5
        }
    }

    */

    class Pragin
    {
        public static void Main()
        {
            List<Employee> emplist = new List<Employee>();

            emplist.Add(new Employee() { id = 101, name = "marry", salary = 5000, experience = 5 });
            emplist.Add(new Employee() { id = 102, name = "mike", salary = 10000, experience = 3 });
            emplist.Add(new Employee() { id = 103, name = "john", salary = 4000, experience = 4 });
            emplist.Add(new Employee() { id = 104, name = "todd", salary = 12000, experience = 8 });

            Employee.PromoteEmployee(emplist);
        }
    }

    delegate bool IsPromotable(Employee empl);
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }    
        public int salary { get; set; }
        public int experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeelist)
        {
            foreach (Employee employee in employeelist)
            {
                if (employee.experience>= 5)
                {
                    Console.WriteLine(employee.name + " " + "promoted");
                }
            }

            foreach (Employee employee in employeelist)
            {
                if (employee.salary >= 5000)
                {
                    Console.WriteLine(employee.name + " " + "promoted");
                }
            }

        }
    }
}
