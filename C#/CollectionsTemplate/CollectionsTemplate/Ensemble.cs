using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsTemplate
{
    class Ensemble<T> : List<T>
    {
        public void Add(T elem)
        {
            if (!this.Contains(elem))
                base.Add(elem);
        }
    }
}
