using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_2
{
    class Compte
    {
        private static int cpt = 0;
        private readonly int num;
        private Client C;
        private Devise solde;
        private List<Operation> op;

        public Compte()
        {
            num = cpt++;
        }
        public Compte(Client c, Devise s)
        {
            num = cpt++;
            C = c;
            solde = s;
        }
        public void Affiche()
        {
            Console.WriteLine(num);
            C.affiche_c();
            solde.affiche_s();
        }
        public void Credite(Devise s)
        {
            this.solde = s + this.solde;
            Operation OP = new Operation(s, "+");
            this.op.Add(OP);
        }
        public virtual Boolean Debiter(Devise s, Devise plafond)
        {
            if (s <= plafond)
            {
                this.solde = this.solde - s;
                Operation OP = new Operation(s, "+");
                this.op.Add(OP);
                return true;
            }
            return false;
        }
        public void virement(Devise s, Devise plafond, Compte V)
        {
            if (this.Debiter(s, plafond))
                 V.Credite(s);
        }
        public void maj_solde(double intert)
        {
            this.solde = this.solde + (this.solde * intert);
        }
    }
}
