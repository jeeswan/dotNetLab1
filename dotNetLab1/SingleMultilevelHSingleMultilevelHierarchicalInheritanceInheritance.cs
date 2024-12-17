using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetLab1
{
    // Single Inheritance: Base Class
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("This animal eats food.");
        }
    }

    // Single Inheritance: Derived Class
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    // Multilevel Inheritance: Derived from Dog
    class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("The puppy weeps.");
        }
    }

    // Hierarchical Inheritance: Another class derived from Animal
    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("The cat meows.");
        }
    }
    internal class SingleMultilevelHierarchicalInheritance
    {
        public void Inheritance()
        {
            // Single Inheritance
            Dog dog = new Dog();
            Console.WriteLine("Single Inheritance:");
            dog.Eat();
            dog.Bark();

            // Multilevel Inheritance
            Puppy puppy = new Puppy();
            Console.WriteLine("\nMultilevel Inheritance:");
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();

            // Hierarchical Inheritance
            Cat cat = new Cat();
            Console.WriteLine("\nHierarchical Inheritance:");
            cat.Eat();
            cat.Meow();

            Console.ReadLine();
        }
    }
}
