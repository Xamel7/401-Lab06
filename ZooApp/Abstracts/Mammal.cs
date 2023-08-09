using System;

namespace ZooApp.Abstracts
{
    public abstract class Mammal : Animal
    {
        public string FurColor;

        public abstract void Walk();

        public override string AnimalType => "Mammal";

        public void DisplayType()
        {
            Console.WriteLine($"This animal is a: {AnimalType}");
        }
    }
}
