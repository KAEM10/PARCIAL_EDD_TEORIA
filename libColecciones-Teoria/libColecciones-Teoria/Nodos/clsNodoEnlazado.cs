using System;

namespace Servicios.Colecciones.Nodos
{
    public class clsNodoEnlazado<Tipo>:clsNodo<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        #region Asociativo
        private clsNodoEnlazado<Tipo> atrSiguiente;
        #endregion 
        #endregion
    }
}
