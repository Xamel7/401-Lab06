using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.Abstracts;

namespace ZooApp
{
    public class Rhino : Mammal
    {
        // Charge method specific to Rhino behavior
        public void Charge()
        {
            Console.WriteLine("AAAAAAHHHHHHHAHAHHHH!!!!!!");
        }

        // Overridden Walk method from Mammal class
        public override void Walk()
        {
            Console.WriteLine("Walk on HOOVES");
        }

        // Virtual Eat method that can be overridden in derived classes
        public virtual void Eat()
        {
            Console.WriteLine("A satisfying meal.");
        }

        // Override Move method (Note: throw exception as it's not implemented here)
        public override void Move()
        {
            throw new NotImplementedException();
        }

        // Override Animal_Nation method (Note: throw exception as it's not implemented here)
        public override void Animal_Nation()
        {
            throw new NotImplementedException();
        }

        // Override Breathe method (Note: throw exception as it's not implemented here)
        public override void Breathe()
        {
            throw new NotImplementedException();
        }
    }
}