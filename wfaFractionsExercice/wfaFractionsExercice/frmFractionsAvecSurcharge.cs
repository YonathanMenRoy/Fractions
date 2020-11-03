using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaFractionsExercice
{
    public partial class frmFractionsAvecSurcharge : Form
    {
        Fraction fraction1;
        Fraction fraction2;
        public frmFractionsAvecSurcharge()
        {
            InitializeComponent();

        }

        private void frmFractionsAvecSurcharge_Load(object sender, EventArgs e)
        {
            lblNumReponse.Visible = false;
            lblDenomReponse.Visible = false;

        }

        private void btnAdditioner_Click(object sender, EventArgs e)
        {
            ConvertirEnEntier();
            try
            {
                Fraction reponse = fraction1 + fraction2;
                reponse = reponse.ReduireFraction(reponse);
                lblNumReponse.Text = reponse.Numerateur.ToString();
                lblDenomReponse.Text = reponse.Denominateur.ToString();

                Affichelabel();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void ConvertirEnEntier()
        {
            IList<Fraction> donnees = new List<Fraction>();
            int numFraction1 = 0;
            int numFraction2 = 0;
            int denomFraction1= 0;
            int denomFraction2= 0;
            try
            {
                 numFraction1 = Convert.ToInt32(txtNumFraction1.Text);
                 numFraction2 = Convert.ToInt32(txtNumFraction2.Text);
                 denomFraction1 = Convert.ToInt32(txtDenomFraction1.Text);
                 denomFraction2 = Convert.ToInt32(txtDenomFraction2.Text);
                fraction1 = new Fraction(numFraction1, denomFraction1);
                fraction2 = new Fraction(numFraction2, denomFraction2);
            }
            catch (Exception)
            {
                 MessageBox.Show(new EntreeInvalideException().Message);
            }

           

            
        } 

        private void Affichelabel()
        {
            lblNumReponse.Visible = true;
            lblDenomReponse.Visible = true;
        }

        private void btnSoustraire_Click(object sender, EventArgs e)
        {
            ConvertirEnEntier();
            try
            {
                Fraction reponse = fraction1 - fraction2;
                reponse = reponse.ReduireFraction(reponse);
                lblNumReponse.Text = reponse.Numerateur.ToString();
                lblDenomReponse.Text = reponse.Denominateur.ToString();

                Affichelabel();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnMultiplier_Click(object sender, EventArgs e)
        {
            ConvertirEnEntier();
            try
            {
                Fraction reponse = fraction1 * fraction2;
                reponse = reponse.ReduireFraction(reponse);
                lblNumReponse.Text = reponse.Numerateur.ToString();
                lblDenomReponse.Text = reponse.Denominateur.ToString();

                Affichelabel();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
