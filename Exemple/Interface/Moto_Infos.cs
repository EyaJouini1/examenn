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
    public partial class Moto_Infos : Form
    {
        public Moto_Infos(Moto m)
        {
            InitializeComponent();
            textImm.Text = m.Immatriculation;
            ListViewItem item = new ListViewItem();
            item.Text = m.Cylindre.ToString();
            item.SubItems.Add(m.VitesseMax.ToString());
            listView1.Items.Add(item);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
