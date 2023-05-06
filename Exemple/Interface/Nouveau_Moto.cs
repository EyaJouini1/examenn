using Parte_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Nouveau_Moto : Form
    {
        public Moto moto;

        public Nouveau_Moto(Moto a)
        {
            InitializeComponent();
            this.moto = a;
        }

        private void AjouterM_Click(object sender, EventArgs e)
        {
            moto.Annee = int.Parse(textAnnee.Text);
            moto.Immatriculation = textImm.Text;
            moto.Cylindre = double.Parse(textCylindre.Text);
            moto.VitesseMax =int.Parse(textVitesse.Text);
            this.Close();
        }
    }
}
