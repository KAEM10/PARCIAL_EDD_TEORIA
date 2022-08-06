using System;
using Servicios.Colecciones.Nodos;

namespace Servicios.Colecciones.Interfaces
{
    public interface iTADDobleEnlazado<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Getters
        clsNodoDobleEnlazado<Tipo> darPrimero();
        clsNodoDobleEnlazado<Tipo> darUltimo();
        #endregion
    }
}
