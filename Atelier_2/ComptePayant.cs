using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_2
{
    class ComptePayant:Compte
    {
        private static double payment ;

        public ComptePayant() { }
        public ComptePayant(double p)
        {
            payment = p;
        }
        public override Boolean Debiter(Devise s, Devise plafond)
        {
            Devise dev = new Devise();
            dev = s + s * payment;
            return base.Debiter(dev, plafond);
        }
    }
}
