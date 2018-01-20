using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChienMaitre
{
    public class MaitreMalvoyant : Maitre
    {
        public int niveauInfirmite;

        public MaitreMalvoyant(String n, int nivInf) : base (n)
        { niveauInfirmite = nivInf; }


        public bool possedeChienDAveugle()
        {
            bool possede = false;
            foreach (Chien c in lesChiens)
            {
                possede = possede ||
                          System.Type.GetType("ChienMaitre.ChienDAveugle").IsAssignableFrom(c.GetType());
            }
            return possede;
        }



        override public bool estProtege()
        {
            return base.estProtege() && possedeChienDAveugle();
        }

    }
}
