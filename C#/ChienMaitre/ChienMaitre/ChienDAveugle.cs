using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChienMaitre
{
    public class AgeInadapteException : Exception
    {
        public AgeInadapteException() { }
        public AgeInadapteException(string mess) : base(mess) { }
    }
    public class ChienDAveugle : Chien
    {
        public DateTime dateNaissance;
        public String organisme;
        const int ageMin = 3;
        const int ageMax = 7;

        public ChienDAveugle(String n, bool f, Maitre m, DateTime dN, String o)
            : base(n, f, m)
        {
            if (m != null && m.GetType() == System.Type.GetType("ChienMaitre.MaitreMalvoyant"))
            {
                if ((DateTime.Now - dN).TotalDays > ageMax*365 || (DateTime.Now - dN).TotalDays < ageMin*365)
                {
                    throw new AgeInadapteException("" + ((DateTime.Now - dN).TotalDays / 365));
                }
            }

            dateNaissance = dN;
            organisme = o;
        }
    }
}
