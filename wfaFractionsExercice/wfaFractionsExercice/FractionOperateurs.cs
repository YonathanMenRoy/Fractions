using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaFractionsExercice
{
    public partial class Fraction
    {
        public static Fraction operator+(Fraction fraction1, Fraction fraction2)
        {
            Fraction reponse;
            int numReponse;
            int denomReponse;
            Fraction memoire = fraction1;
            fraction1.Numerateur = fraction1.Numerateur * fraction2.Denominateur;
            fraction1.Denominateur = fraction1.Denominateur * fraction2.Denominateur;
            fraction2.Numerateur = fraction2.Numerateur * memoire.Denominateur;
            fraction2.Denominateur = fraction2.Denominateur * memoire.Denominateur;
            numReponse = fraction2.Numerateur + fraction1.Numerateur;
            denomReponse = fraction2.Denominateur;
            reponse = new Fraction()
        }
    }
}
