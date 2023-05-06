using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parte_1;
namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Automobile> listAuto = new List<Automobile>();

        public Garage garage = new Garage();
        private void buttonAjout_Click(object sender, EventArgs e)
        {
            if (radioVoiture.Checked)
            { 
                Voiture v = new Voiture();
            Nouvelle_Voiture nv =
                new Nouvelle_Voiture(v);
            if (nv.ShowDialog() == DialogResult.OK)
            {
                garage.AddAuto(v);
            }
            listAuto = garage.
                AfficherAutomobiles(SubType.Voiture);
            remplirListe();

        }

            else if (radioMoto.Checked)
            {
                Moto m = new Moto();
                Nouveau_Moto nv = new Nouveau_Moto(m);
                if (nv.ShowDialog() == DialogResult.OK)
                {
                    garage.AddAuto(m);
                }

                listAuto = garage.AfficherAutomobiles(SubType.Moto);
                remplirListe();


            }

        }
        private void remplirListe()
        {
            listBox1.Items.Clear();
            foreach (Automobile a in listAuto)
            {
                listBox1.Items.Add(a);
            }
        }
        private void remplirChamps()
        {
            Automobile au = listBox1.SelectedItem
                as Automobile;
            lImm.Text = au.Immatriculation;
            lAnn.Text = au.Annee.ToString();
            lType.Text = radioMoto.Checked ?
                "Moto" : "Voiture";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (i != -1)
            {
                if (radioVoiture.Checked)
                {

                    Voiture v = listAuto[i] as Voiture;
                    Voiture_Infos vi = new Voiture_Infos(v);
                    vi.Show();
                }
                else if (radioMoto.Checked)
                {
                    Moto m = listAuto[i] as Moto;
                    Moto_Infos mi = new Moto_Infos(m);
                    mi.Show();

                }


            }

        }
      
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirChamps();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioVoiture_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioMoto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lType_Click(object sender, EventArgs e)
        {

        }

        private void lAnn_Click(object sender, EventArgs e)
        {

        }

        private void lImm_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonSupprimer_Click_1(object sender, EventArgs e)
        {
            
                Automobile au = listBox1.SelectedItem as Automobile;
                garage.DeleteAuto(au.Immatriculation);
                if (radioVoiture.Checked)
                    listAuto = garage.AfficherAutomobiles(SubType.Voiture);
                else
                    listAuto = garage.AfficherAutomobiles(SubType.Moto);

                remplirListe();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        { int i = listBox1.SelectedIndex;
            if (i != -1)
            {
                if (radioVoiture.Checked)
                {

                    Voiture v = listAuto[i] as Voiture;
        Voiture_Infos vi = new Voiture_Infos(v);
        vi.Show();
                }
                else if (radioMoto.Checked)
                {
                    Moto m = listAuto[i] as Moto;
    Moto_Infos mi = new Moto_Infos(m);
    mi.Show();

                }

            }

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            remplirChamps();
        }
    }
}
