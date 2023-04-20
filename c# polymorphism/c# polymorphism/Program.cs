using System;

/*
// method overriding
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes sound.");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks.");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows.");
    }
}

class Program
{
    static void Main()
    {
        Animal animal1 = new Animal();
        Animal animal2 = new Dog();
        Animal animal3 = new Cat();

        animal1.MakeSound(); // Output: Animal makes sound.
        animal2.MakeSound(); // Output: Dog barks.
        animal3.MakeSound(); // Output: Cat meows.
    }
}
*/


/*
// interface

interface IAnimal
{
    void MakeSound();
}

class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Dog barks.");
    }
}

class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Cat meows.");
    }
}

class Program
{
    static void Main()
    {
        IAnimal animal1 = new Dog();
        IAnimal animal2 = new Cat();

        animal1.MakeSound(); // Output: Dog barks.
        animal2.MakeSound(); // Output: Cat meows.
    }
}

*/

//abstract class

abstract class Animal
{
    public abstract void MakeSound();
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks.");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows.");
    }
}

class Program
{
    static void Main()
    {
        Animal animal1 = new Dog();
        Animal animal2 = new Cat();

        animal1.MakeSound(); // Output: Dog barks.
        animal2.MakeSound(); // Output: Cat meows.
    }
}

