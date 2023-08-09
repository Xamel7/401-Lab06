using System;

namespace ZooApp.Abstracts
{
    public class Bird : Animal
    {
        int WingSpan;

        public override string AnimalType => "Bird";

        public void DisplayType()
        {
            Console.WriteLine($"This animal is a: {AnimalType}");
        }

        public virtual void Fly()
        {
            Console.WriteLine("Free your mind. Let go of it all.");
        }
        public virtual void Eat()
        {
            Console.WriteLine("A satisftying meal.");
        }

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