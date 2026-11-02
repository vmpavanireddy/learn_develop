using System;

class day_27
{
    public static void Main(string[] args)
    {
        Animal pet = new Dog();
        pet.Speak();
    }
}

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Woof!");
    }
}