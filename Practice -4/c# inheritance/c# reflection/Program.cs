using System;
using System.Reflection;

class Program
{
    /*
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
    */
    static void Main()
    {
        // Get the type information for a class
        Type type = typeof(Person);

        // Get the assembly information where the type is defined
        Assembly assembly = type.Assembly;
        Console.WriteLine($"Assembly : {assembly.FullName}");

        //get the namespace and name of the type
        string @namespace = type.Namespace;
        string name = type.Name;
        Console.WriteLine($"Namespace : {@namespace}");
        Console.WriteLine($"Type name : {@name}");

        //get the constuctor of the type 
        ConstructorInfo[] constructors = type.GetConstructors();
        Console.WriteLine("Constructors");
        foreach (ConstructorInfo constructor in constructors)
        {
            Console.WriteLine(constructor.ToString());
        }

        //get the properties of type 
        PropertyInfo[] properties = type.GetProperties();
        Console.WriteLine("Properties:");
        foreach (PropertyInfo property in properties)
        {
            Console.WriteLine(property.ToString());
        }

        //get the method of the type
        MethodInfo[] methods = type.GetMethods();
        Console.WriteLine("Methods:");
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine(method.ToString());
        }
    }
}

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public void SayHello()
    {
        Console.WriteLine($"Hello, my name is {FirstName} {LastName} !");
    }
}

