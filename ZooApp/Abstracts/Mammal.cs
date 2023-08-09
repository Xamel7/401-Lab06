using System;

namespace ZooApp.Abstracts
{
    // Abstract class Mammal inheriting from Animal
    public abstract class Mammal : Animal
    {
        // Public property to hold fur color of the mammal
        public string FurColor;

        // Abstract method defining walking behavior for mammals
        public abstract void Walk();

        // Override the AnimalType property from the base class
        public override string AnimalType => "Mammal";

        // Method to display the type of the animal
        public void DisplayType()
        {
            Console.WriteLine($"This animal is a: {AnimalType}");
        }
    }
}