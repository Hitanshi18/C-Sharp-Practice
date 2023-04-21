using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        // Create an instance of a class
        MyClass obj = new MyClass();

        // Get the type of the object
        Type type = obj.GetType();

        // Display the type name
        Console.WriteLine("Type name: " + type.FullName);

        // Display the properties of the object
        PropertyInfo[] properties = type.GetProperties();
        Console.WriteLine("Properties:");
        foreach (PropertyInfo property in properties)
        {
            Console.WriteLine(property.Name + " (Type: " + property.PropertyType.Name + ")");
        }

        // Display the methods of the object
        MethodInfo[] methods = type.GetMethods();
        Console.WriteLine("Methods:");
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine(method.Name);
        }

        // Invoke a method dynamically
        MethodInfo methodInfo = type.GetMethod("TestMethod");
        methodInfo.Invoke(obj, null);

        // Access a property dynamically
        PropertyInfo propertyInfo = type.GetProperty("MyProperty");
        propertyInfo.SetValue(obj, "NewValue");
        Console.WriteLine("MyProperty: " + propertyInfo.GetValue(obj));

        // Display the attributes of the object
        Attribute[] attributes = Attribute.GetCustomAttributes(type);
        Console.WriteLine("Attributes:");
        foreach (Attribute attribute in attributes)
        {
            Console.WriteLine(attribute.GetType().Name);
        }
    }
}

class MyClass
{
    public string MyProperty { get; set; }

    public void TestMethod()
    {
        Console.WriteLine("TestMethod invoked");
    }
}
