using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.Interfaces
{
    public interface IWalker
    {
        public int Legs { get; set; }

        public void Walk();
    }
}
