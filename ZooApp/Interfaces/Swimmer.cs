using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.Interfaces
{
    public interface ISwimmer
    {
        public int Gills { get; set; }

        public void Swimmer();
    }
}
