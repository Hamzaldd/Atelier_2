using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_2
{
    class CompteEpargne : Compte
    {
        private double TauxIntert;
        public void calculInteret()
        {
            this.maj_solde(TauxIntert);
        }
    }
}
