using System;

namespace ZooApp.Abstracts
{
    public class Fish : Animal
    {
        int GillSize;

        public void Swim()
        {
            Console.WriteLine("Just keep swimming");
        }

        public override string AnimalType => "Fish";

        public void DisplayType()
        {
            Console.WriteLine($"This animal is a: {AnimalType}");
        }
        public virtual void Eat()
        {
            Console.WriteLine("A satisftying meal.");
        }

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