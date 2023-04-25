using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__override_ToString
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // Constructor
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;

            Person person = new Person("John", "Doe", 30);
            Console.WriteLine(person.ToString()); // Output: FirstName: John, LastName: Doe, Age: 30

        }

        // Override ToString() method
        public override string ToString()
        {
            return $"FirstName: {FirstName}, LastName: {LastName}, Age: {Age}";
        }
    }


}
