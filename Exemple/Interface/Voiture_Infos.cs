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
    public partial class Voiture_Infos : Form
    {
        public Voiture_Infos(Voiture v)
        {
            InitializeComponent();
            textImm.Text = v.Immatriculation;
            ListViewItem item = new ListViewItem();
            item.Text = v.Couleur;
            item.SubItems.Add(v.Marque);
            item.SubItems.Add(v.TypeV);
            listView1.Items.Add(item);
        }

        private void textImm_Click(object sender, EventArgs e)
        {

        }
    }
}
