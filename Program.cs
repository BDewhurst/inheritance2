// See https://aka.ms/new-console-template for more information
// class animals properties name age ishungry 
// constructor makesound eat play. 
using System;

namespace VirtualOverideDemo
{
    class Program
    {
        static void Main (string[] args)
        {
            Dog doggy = new Dog("Stevo", 15);
            Console.WriteLine($"{doggy.Name} is {doggy.Age} years old");
            doggy.Play();
            doggy.Eat();
            doggy.MakeSound();
        }
    }
}