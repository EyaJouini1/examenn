using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_2
{
   
        public class Moto : Automobile
        {
            private double cylindre;

            public double Cylindre
            {
                get { return cylindre; }
                set { cylindre = value; }
            }
            private int vitesseMax;

            public int VitesseMax
            {
                get { return vitesseMax; }
                set { vitesseMax = value; }
            }


            public override string ToString()
            {
                return base.ToString() + " Cylindre: " + Cylindre + " Vitesse max: " + VitesseMax;
            }

            public Moto(int annee, string immatriculation, double cylindre, int vitesseMax)
                : base(annee, immatriculation)
            {
                Cylindre = cylindre;
                VitesseMax = vitesseMax;
            }

            public Moto()
            {
            }
        }
}
