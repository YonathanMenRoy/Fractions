using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaFractionsExercice
{
    public partial class Fraction
    {
        private static IList<Fraction> MettreSurMemeDenominateur(Fraction fraction1, Fraction fraction2)
        {
            
            int denomMemoire = fraction1.Denominateur;
            fraction1.Numerateur = fraction1.Numerateur * fraction2.Denominateur;
            fraction1.Denominateur = fraction1.Denominateur * fraction2.Denominateur;
            fraction2.Numerateur = fraction2.Numerateur * denomMemoire;
            fraction2.Denominateur = fraction2.Denominateur * denomMemoire;
            IList<Fraction> fractions = new List<Fraction>();

            fractions.Add(fraction1);
            fractions.Add(fraction2);

            return fractions;
        }

        public static Fraction operator+(Fraction fraction1, Fraction fraction2)
        {
            Fraction reponse;
            int numReponse;
            int denomReponse;

            IList<Fraction> fractions = MettreSurMemeDenominateur(fraction1, fraction2);

            fraction1 = fractions[0];
            fraction2 = fractions[1];

            numReponse = fraction2.Numerateur + fraction1.Numerateur;
            denomReponse = fraction2.Denominateur;
            reponse = new Fraction(numReponse, denomReponse);
            return reponse;
        }

        public static Fraction operator-(Fraction fraction1, Fraction fraction2)
        {
            Fraction reponse;
            int numReponse;
            int denomReponse;

            IList<Fraction> fractions = MettreSurMemeDenominateur(fraction1, fraction2);

            fraction1 = fractions[0];
            fraction2 = fractions[1];

            numReponse = fraction1.Numerateur - fraction2.Numerateur;
            denomReponse = fraction2.Denominateur;
            reponse = new Fraction(numReponse, denomReponse);
            return reponse;
        }

        public static Fraction operator*(Fraction fraction1, Fraction fraction2)
        {
            Fraction reponse;
            int numReponse;
            int denomReponse;

            numReponse = fraction1.Numerateur * fraction2.Numerateur;
            denomReponse = fraction1.Denominateur * fraction2.Denominateur;
            reponse = new Fraction(numReponse, denomReponse);
            return reponse;
        }
    }
}
