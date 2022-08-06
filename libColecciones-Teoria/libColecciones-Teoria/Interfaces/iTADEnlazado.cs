using System;
using Servicios.Colecciones.Nodos;

namespace Servicios.Colecciones.Interfaces
{
    public interface iTADEnlazado<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Getters
        clsNodoEnlazado<Tipo> darPrimero();
        clsNodoEnlazado<Tipo> darUltimo();
        #endregion
    }
}
