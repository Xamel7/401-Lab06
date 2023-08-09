using System;

namespace ZooApp.Abstracts
{
    // Class Bird inheriting from Animal
    public class Bird : Animal
    {
        // Private field to hold wingspan of the bird
        int WingSpan;

        // Override the AnimalType property from the base class
        public override string AnimalType => "Bird";

        // Method to display the type of the animal
        public void DisplayType()
        {
            Console.WriteLine($"This animal is a: {AnimalType}");
        }

        // Virtual method to represent flying behavior of bird
        public virtual void Fly()
        {
            Console.WriteLine("Free your mind. Let go of it all.");
        }

        // Virtual method to represent eating behavior of bird
        public virtual void Eat()
        {
            Console.WriteLine("A satisfying meal.");
        }

        // Override methods related to Animal_Nation, Breathe, and Move (implement as needed)
        public override void Animal_Nation()
        {
            throw new NotImplementedException();
        }

        public override void Breathe()
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}