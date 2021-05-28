using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint3WPF
{
    class Schraubenkopf
    {
        public Schraubenkopf(double wert1, double wert2, double wert3)
        {
            this.wert1 = wert1;
            this.wert2 = wert2;
            this.wert3 = wert3;
        }

        public double wert1 { get; private set; }
        public double wert2 { get; private set; }
        public double wert3 { get; private set; }
    }
}
