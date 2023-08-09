using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.Abstracts
{
    // Abstract class Animal serving as a base for other animal classes
    public abstract class Animal
    {
        // Virtual method representing sleep behavior of animals
        public virtual void Sleep()
        {
            Console.WriteLine("*SNORE**SNORE*");
        }

        // Abstract property to get the type of the animal
        public abstract string AnimalType { get; }

        // Method to display the type of the animal
        public void DisplayType()
        {
            Console.WriteLine($"This animal is a: {AnimalType}");
        }

        // Virtual method representing eating behavior of animals
        public virtual void Eat()
        {
            Console.WriteLine("A satisfying meal.");
        }

        // Abstract method for breathing behavior (to be implemented in derived classes)
        public abstract void Breathe();

        // Abstract method for movement behavior (to be implemented in derived classes)
        public abstract void Move();

        // Abstract method for animal's nation (to be implemented in derived classes)
        public abstract void Animal_Nation();
    }
}