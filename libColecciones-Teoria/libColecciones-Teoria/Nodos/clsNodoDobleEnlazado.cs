using System;

namespace Servicios.Colecciones.Nodos
{
    public class clsNodoDobleEnlazado<Tipo>:clsNodo<Tipo> where Tipo:IComparable<Tipo>
    {
        #region Atributos
        #region Asociativo
        private clsNodoDobleEnlazado<Tipo> atrAnterior;
        private clsNodoDobleEnlazado<Tipo> atrSiguiente;
        #endregion 
        #endregion
    }
}
