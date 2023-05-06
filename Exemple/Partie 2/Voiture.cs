using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_2
{
    public class Voiture : Automobile
    {
        private string couleur;

        public string Couleur
        {
            get { return couleur; }
            set { couleur = value; }
        }
        private string marque;

        public string Marque
        {
            get { return marque; }
            set { marque = value; }
        }
        private string typeV;

        public string TypeV
        {
            get { return typeV; }
            set { typeV = value; }
        }



        public override string ToString()
        {
            return base.ToString() + " couleur: " + Couleur + " marque: " + Marque + " typeV: " + TypeV;
        }

        public Voiture(int annee, string immatriculation,
            string couleur, string marque, string typeV)
            : base(annee, immatriculation)
        {
            Couleur = couleur;
            Marque = marque;
            TypeV = typeV;
        }

        public Voiture()
        {
        }
    }
}