using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__attributes
{

    // Define a custom attribute
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class CustomAttribute : Attribute
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public CustomAttribute(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    // Use the custom attribute
    [Custom("John", 30)]
    [Custom("Alice", 25)]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        [Custom("PrintInfo", 40)]
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Retrieve attribute values using reflection
            Type type = typeof(Person);
            CustomAttribute[] classAttributes = (CustomAttribute[])type.GetCustomAttributes(typeof(CustomAttribute), false);
            foreach (var attribute in classAttributes)
            {
                Console.WriteLine($"Name: {attribute.Name}, Age: {attribute.Age}");
            }

            var person = new Person("John", "Doe");
            Type methodType = typeof(Person);
            var methodInfo = methodType.GetMethod("PrintInfo");
            CustomAttribute[] methodAttributes = (CustomAttribute[])methodInfo.GetCustomAttributes(typeof(CustomAttribute), false);
            foreach (var attribute in methodAttributes)
            {
                Console.WriteLine($"Name: {attribute.Name}, Age: {attribute.Age}");
            }
        }
    }


    /*
    public class MainClass
    {
        private static void Main()
        {
            //Calculator.Add(10, 20);
        }
    }
    public class Calculator
    {
        [ObsoleteAttribute ("Use Add (List<int> numbers)Method",  true)]
        public static int Add(int firstnumber, int secondnumber) 
        {
          return firstnumber + secondnumber;
        }

        public static int Add(int firstnumber, int secondnumber, int thirdumber)
        {
            return firstnumber + secondnumber + thirdumber;
        }

        public static int Add(List<int> numbers)
        {
            int sum = 0;
           foreach(int number in numbers)
            {
                sum = sum + number;
            }
           return sum;
        }
    }  */
}
