using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.Abstracts
{
    public abstract class Animal
    {
        public virtual void Sleep()
        {
            Console.WriteLine("*SNORE**SNORE*");
        }

        public virtual void Eat()
        {
            Console.WriteLine("A satisfying meal.");
        }
        public abstract void Breathe();

        public abstract void Move();

        public abstract void Animal_Nation();
    }
}
