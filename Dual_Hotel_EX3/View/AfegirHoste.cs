using Dual_Hotel_EX3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dual_Hotel_EX3.View
{
    public partial class AfegirHoste : Form
    {

        public Hoste hoste = null;

        string Nom = null;
        string DNIPasaport = null;
        string Telefon = null;
        string Nacionalitat = null;
        string Adreca = null;
        int Codipostal = 0;
        string Poblacio = null;

        public AfegirHoste()
        {
            InitializeComponent();
        }

        private void checkHoste() {

            try
            {

                // string nom, string dNIPasaport, string telefon, string nacionalitat, string adreca, int codipostal, string poblacio
                hoste = new Hoste(Nom, DNIPasaport, Telefon, Nacionalitat, Adreca, Codipostal, Poblacio);
            }
            catch (Exception ex) {
                Console.WriteLine("VALORS EN NULL!");
            }

        }


        private void AfegirClientLabel_Click(object sender, EventArgs e)
        {

        }

        private void NomLabel_Click(object sender, EventArgs e)
        {

        }

        private void NomInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void AfegirClientB_Click(object sender, EventArgs e)
        {

        }
    }
}
