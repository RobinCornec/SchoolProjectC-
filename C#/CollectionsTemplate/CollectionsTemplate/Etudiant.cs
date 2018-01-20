using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsTemplate
{
    public class ComparateurEtudiant : IComparer<Etudiant>
    {
        public int Compare(Etudiant e1, Etudiant e2) 
        {
            if (e1 == null && e2 == null)
                return 0;
            else if (e1 == null)
                return -1;
            else if (e2 == null)
                return 1;
            else{
                if (e1.nom.Equals(e2.nom))
                    return e1.prenom.CompareTo(e2.prenom);
                else
                    return e1.nom.CompareTo(e2.nom);
            }
        }
    }
    public class Etudiant
    {
        public string nom { get; set; }
        public string prenom { get; set; }

        public Etudiant(string n, string p)
            {nom = n; prenom = p;}

        public override String ToString()
            {return nom + " " + prenom;}

        public override Boolean Equals(Object eComparer)
        {
            if (eComparer == null)
                return false;
            else
            {
                try
                {
                    Etudiant eCmp = (Etudiant)eComparer;

                    if (this.prenom != null && this.prenom != null)
                        return this.nom.Equals(((Etudiant)eComparer).nom) &&
                            this.prenom.Equals(((Etudiant)eComparer).prenom);
                    else
                        return false;
                }
                catch (System.InvalidCastException)
                {
                    return false;
                }

            }
        }
    }
}
