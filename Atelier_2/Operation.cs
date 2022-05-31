using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_2
{
    class Operation
    {
        private int num;
        private DateTime date;
        private Devise d;
        private string lib;

        public Operation() { }
        public Operation(Devise d, string l)
        {
            this.d = d;
            this.lib = l;
        }
    }
}
