using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.Abstracts;
using ZooApp.Interfaces;

namespace ZooApp
{
    public class Monkey : Mammal, IWalker
    {
        // Constructor for the Monkey class
        public Monkey()
        {
        }

        // Property to represent the number of legs
        public int Legs { get; set; }

        // ClimbTree method specific to Monkey behavior
        public void ClimbTree()
        {
            Console.WriteLine("Climb!!");
        }

        // Overridden Walk method from Mammal class
        public override void Walk()
        {
            Console.WriteLine("Walk on paws!");
        }

        // Overridden Move method (same as Walk in this case)
        public override void Move()
        {
            Console.WriteLine("Walk on paws!");
        }

        // Override Breathe method with specific behavior
        public override void Breathe()
        {
            Console.WriteLine("I can breathe. I can FIGHT!");
        }

        // Override Sleep method specific to Monkey behavior
        public override void Sleep()
        {
            Console.WriteLine("rrrrrrrrssspppphhhpssphrrrrr");
        }

        // Virtual Eat method that can be overridden in derived classes
        public virtual void Eat()
        {
            Console.WriteLine("A satisfying meal.");
        }

        // Override Animal_Nation method (Note: throw exception as it's not implemented here)
        public override void Animal_Nation()
        {
            throw new NotImplementedException();
        }
    }
}