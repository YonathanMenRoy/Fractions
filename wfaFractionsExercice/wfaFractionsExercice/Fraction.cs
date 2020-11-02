using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaFractionsExercice
{
    public partial class Fraction
    {
        int Numerateur { get; set; }
        int Denominateur { get; set; }
        public Fraction(int numerateur, int denominateur)
        {
            Numerateur = numerateur;
            Denominateur = denominateur;
        }

        public Fraction ReduireFraction(Fraction fractionAReduire)
        {
            int pgcd = TrouverPGCD(fractionAReduire);
            int num = fractionAReduire.Numerateur;
            int denom = fractionAReduire.Denominateur;
            Fraction fractionReduite;

            if (pgcd != 1 )
            {
                num = Diviser(num, pgcd);
                denom = Diviser(denom, pgcd);
                fractionReduite = new Fraction(num, denom);
                return fractionReduite;
            }
            else
            {
                return fractionAReduire;
            }
        }

        private int TrouverPGCD(Fraction fraction)
        {
            int num = fraction.Numerateur;
            int denom = fraction.Denominateur;

            while (num != denom)
            {
                if (num < denom)
                {
                    denom = denom - num;
                }
                else
                {
                    num = num - denom;
                }
            }
            return num;
        }

        private int Diviser(int dividende, int diviseur)
        {
            int quotient = 0;

            while (dividende >= diviseur)
            {
                dividende = dividende - diviseur;
                quotient++;
            }
            return quotient;
        }
    }
}
