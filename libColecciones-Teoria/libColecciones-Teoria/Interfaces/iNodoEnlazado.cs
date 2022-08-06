using System;
using Servicios.Colecciones.Nodos;

namespace Servicios.Colecciones.Interfaces
{
    public interface iNodoEnlazado<Tipo> :iNodo<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Getters
        clsNodoEnlazado<Tipo> darSiguiente();
        #endregion

        #region Setters
        bool ponerSiguiente();
        #endregion
    }
}
