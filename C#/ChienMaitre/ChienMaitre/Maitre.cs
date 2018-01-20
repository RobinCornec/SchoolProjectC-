using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChienMaitre
{
    public class MaitreDifferentException : Exception
    { 
      public MaitreDifferentException() { }
      public MaitreDifferentException(string mess) : base(mess) { }
    }

    public class Maitre
    {
        public String nom {get; set;}
        protected List<Chien> lesChiens = new List <Chien>();
        protected int nombreChiens { set { } get { return lesChiens.Count; } }

        public Maitre(String n)
        {
            nom = n;
        }

        public void ajouterChien(Chien c)
        {
            if (c.getMaitre() != null)
            {
                if (c.getMaitre().Equals(this))
                {
                    lesChiens.Add(c);
                }
                else
                {
                    throw new MaitreDifferentException("chien (" + c.getMaitre().nom + ") et maitre (" + nom + ")");
                }  
            }
            else
            {
                c.leMaitre = this;
            }
            
        }

        virtual public bool estProtege()
        {
            return nombreChiens > 0;
        }

        public void PossedeChien() 
        {

        }

    }
}
