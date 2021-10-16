using System;

namespace Task3
{
    interface IAnimal
    {
        public void MakeSound();
    }

    class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
    class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof-Woof");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.MakeSound();

            Dog dog = new Dog();
            dog.MakeSound();
        }
    }
}
