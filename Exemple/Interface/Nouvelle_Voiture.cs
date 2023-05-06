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
    public partial class Nouvelle_Voiture : Form
    {
        public Voiture voiture;
        public Nouvelle_Voiture(Voiture a)
        {
            InitializeComponent();
            this.voiture = a;
        }

        private void textMarq_TextChanged(object sender, EventArgs e)
        {

        }

        private void AjouterV_Click(object sender, EventArgs e)
        {
            voiture.Annee =
                int.Parse
                (textAnnee.Text);
            voiture.Immatriculation =
                textImm.Text;
            voiture.Couleur =
                textCoul.Text;
            voiture.Marque =
                textMarq.Text;
            voiture.TypeV =
                textType.Text;
            this.Close();

        }
    }
}
