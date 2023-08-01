using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Monkey : Mammal
    {
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
            Console.WriteLine("*SNORE**SNORE*");
        }

    }

}
