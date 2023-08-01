using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Rhino : Mammal
    {
        public void Charge()
        {
            Console.WriteLine("AAAAAAHHHHHHHAHAHHHH!!!!!!");
        }

        public override void Walk()
        {
            Console.WriteLine("Walk on HOOVES");
        }

    }

}
