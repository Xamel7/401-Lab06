using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.Interfaces
{
    // IWalker interface represents animals that can walk
    public interface IWalker
    {
        // Property to represent the number of legs
        public int Legs { get; set; }

        // Walk method for animals that can walk
        public void Walk();
    }
}