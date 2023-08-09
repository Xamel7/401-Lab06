using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.Interfaces
{
    // ISwimmer interface represents animals that can swim
    public interface ISwimmer
    {
        // Property to represent the number of gills
        public int Gills { get; set; }

        // Swimmer method for animals that can swim
        public void Swimmer();
    }
}