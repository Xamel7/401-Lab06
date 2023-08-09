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
        public void Charge()
        {
            Console.WriteLine("AAAAAAHHHHHHHAHAHHHH!!!!!!");
        }

        public override void Walk()
        {
            Console.WriteLine("Walk on HOOVES");
        }

        public virtual void Eat()
        {
            Console.WriteLine("A satisftying meal.");
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }

        public override void Animal_Nation()
        {
            throw new NotImplementedException();
        }

        public override void Breathe()
        {
            throw new NotImplementedException();
        }
    }

}
