using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChienMaitre
{
    public class Chien
    {
        public String nom;
        public bool femelle;
        public Maitre leMaitre;
        public Chien(String n, bool f, Maitre leMaitre)
        {
            nom = n;
            femelle = f;
            this.leMaitre = leMaitre;
        }

        public Maitre getMaitre()
        { return leMaitre; }
        public String getNom()
        { return nom; }
    }
}
