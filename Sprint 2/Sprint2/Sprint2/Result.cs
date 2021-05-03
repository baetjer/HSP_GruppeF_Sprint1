using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class Result
    {
        public Result(double output_gw, double output_s, double output_e, double output_k)
        {
            this.Output_gw = output_gw;
            this.Output_s = output_s;
            this.Output_e = output_e;
            this.Output_k = output_k;
        }

        public double Output_gw { get; set; }
        public double Output_s { get; set; }
        public double Output_e { get; set; }
        public double Output_k { get; set; }
    }
}
