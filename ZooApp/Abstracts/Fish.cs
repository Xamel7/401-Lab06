using System;

namespace ZooApp.Abstracts
{
    // Class Fish inheriting from Animal
    public class Fish : Animal
    {
        // Private field to hold gill size of the fish
        int GillSize;

        // Method to simulate swimming behavior of fish
        public void Swim()
        {
            Console.WriteLine("Just keep swimming");
        }

        // Override the AnimalType property from the base class
        public override string AnimalType => "Fish";

        // Method to display the type of the animal
        public void DisplayType()
        {
            Console.WriteLine($"This animal is a: {AnimalType}");
        }

        // Virtual method to represent eating behavior of fish
        public virtual void Eat()
        {
            Console.WriteLine("A satisfying meal.");
        }

        // Override methods related to Animal_Nation, Move, and Breathe (implement as needed)
        public override void Animal_Nation()
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }

        public override void Breathe()
        {
            throw new NotImplementedException();
        }
    }
}