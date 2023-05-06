using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_2
{
    public class Automobile
    {
        public int Annee { get; set; }
        public string Immatriculation { get; set; }
        public Automobile() { }
        public Automobile(int Annee, string Immatriculation)
        {
            this.Annee = Annee;
            this.Immatriculation = Immatriculation;
        }
        public override string ToString()
        {
            return "Immatriculation: " + this.Immatriculation +
                " Annee: " + this.Annee;
        }
    }
}
