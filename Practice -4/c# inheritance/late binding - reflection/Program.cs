using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace late_binding___reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Load the assembly dynamically
            Assembly assembly = Assembly.LoadFrom("MyLibrary.dll");

            // Get the type information for the class dynamically
            Type type = assembly.GetType("MyLibrary.MyClass");

            // Create an instance of the class dynamically
            object obj = Activator.CreateInstance(type);

            // Invoke a method dynamically
            MethodInfo method = type.GetMethod("MyMethod");
            method.Invoke(obj, null);

            // Access a property dynamically
            PropertyInfo property = type.GetProperty("MyProperty");
            string value = (string)property.GetValue(obj);
            Console.WriteLine($"MyProperty value: {value}");

            // Set a property dynamically
            property.SetValue(obj, "New Value");
            value = (string)property.GetValue(obj);
            Console.WriteLine($"MyProperty value after setting: {value}");

            // Access a field dynamically
            FieldInfo field = type.GetField("MyField");
            int fieldValue = (int)field.GetValue(obj);
            Console.WriteLine($"MyField value: {fieldValue}");

            // Set a field dynamically
            field.SetValue(obj, 42);
            fieldValue = (int)field.GetValue(obj);
            Console.WriteLine($"MyField value after setting: {fieldValue}");
        }
    }
}
