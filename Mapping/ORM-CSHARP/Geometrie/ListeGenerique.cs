using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesGeneriques
{
    public class ListeGenerique<T>
        : IEnumerable<T>
    {
        private List<T> elements;
        public int Count
        {
            get { return this.elements.Count; }
        }
        public T this[int i]
        {
            get { return this.elements[i]; }
            private set { this.elements[i] = value; }
        }

        public ListeGenerique()
        {
            this.elements = new List<T>();
        }

        public void Ajouter(T ajout)
        {
            this.elements.Add(ajout);
        }

        public void Trier(UnDelegueDeTest<T> test)
        {
            for (int i = 0; i < Count - 1; i++)
            {
                for (int j = i + 1; j < Count; j++)
                {
                    if (test(this[i], this[j]))
                    {
                        var aux = this[i];
                        this[i] = this[j];
                        this[j] = aux;
                    }
                }
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            return this.elements.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
