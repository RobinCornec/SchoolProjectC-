using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    /// <summary>
    /// Interface pour une forme géométrique
    /// </summary>
    public interface IForme
    {
        /// <summary>
        /// Calcule le périmètre d'une forme
        /// </summary>
        /// <returns>le périmètre</returns>
        double CalculerPerimetre();

        /// <summary>
        /// Calcule la surface d'une forme
        /// </summary>
        /// <returns>la surface</returns>
        double CalculerSurface();
    }
}
