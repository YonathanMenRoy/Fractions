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
    }
}
