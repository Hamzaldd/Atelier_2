using System;

namespace Atelier_2
{
    class Devise
    {
        private double somme;
        public Devise()
        {
            somme = 0;
        }
        public Devise(double s)
        {
            somme = s;
        }
        public static Devise operator -(Devise x1, Devise x2)
        {
            return new Devise(x1.somme - x2.somme);
        }
        public static Devise operator +(Devise x1, Devise x2)
        {
            return new Devise(x1.somme + x2.somme);
        }
        public static Boolean operator <=(Devise x1, Devise x2)
        {
            if (x1.somme <= x2.somme)
            {
                return true;
            }
            return false;
        }
        public static Boolean operator >=(Devise x1, Devise x2)
        {
            if (x1.somme >= x2.somme)
            {
                return true;
            }
            return false;
        }
        public static Devise operator *(Devise x1, double x)
        {
            return new Devise(x1.somme * x);
        }
        public void affiche_s()
        {
            Console.WriteLine(somme);

        }
    }
}
