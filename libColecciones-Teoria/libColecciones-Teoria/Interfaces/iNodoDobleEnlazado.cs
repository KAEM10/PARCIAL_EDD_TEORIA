using System;
using Servicios.Colecciones.Nodos;

namespace Servicios.Colecciones.Interfaces
{
    public interface iNodoDobleEnlazado<Tipo> : iNodo<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Getters
        clsNodoDobleEnlazado<Tipo> darSiguiente();
        clsNodoDobleEnlazado<Tipo> darAnterior();
        #endregion

        #region Setters
        bool ponerSiguiente();
        bool ponerAnterior();
        #endregion
    }
}
