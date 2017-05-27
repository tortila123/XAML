using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    sealed class Bod
    {
        public Bod(int x, int y, int cislo)
        {
            X = x;
            Y = y;
            this.cislo = cislo;
        }
        public int X;
        public int Y;
        public int cislo;
    }
}
