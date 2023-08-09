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
        public Monkey()
        {
        }
        public int Legs { get; set; }

        public void ClimbTree()
        {
            Console.WriteLine("Climb!!");
        }
        public override void Walk()
        {
            Console.WriteLine("Walk on paws!");
        }

        public override void Move()
        {
            Console.WriteLine("Walk on paws!");
        }


        public override void Breathe()
        {
            Console.WriteLine("I can breathe. I can FIGHT!");
        }


        public override void Sleep()
        {
            Console.WriteLine("rrrrrrrrssspppphhhpssphrrrrr");
        }

        public virtual void Eat()
        {
            Console.WriteLine("A satisftying meal.");
        }

        public override void Animal_Nation()
        {
            throw new NotImplementedException();
        }

    }

}
