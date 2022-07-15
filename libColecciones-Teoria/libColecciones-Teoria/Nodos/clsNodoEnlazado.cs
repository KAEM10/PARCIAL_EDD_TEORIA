using System;

namespace Servicios.Colecciones.Nodos
{
    public class clsNodoEnlazado<Tipo> : clsNodo<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        #region Asociativo
        private clsNodoEnlazado<Tipo> atrSiguiente;
        #endregion 
        #endregion
        #region Constructor
        public clsNodoEnlazado(Tipo prmitem)
        {
            this.atrSiguiente = null;
            this.atrItem = prmitem;
        }
        #endregion
        #region Metodo pasaritems
        public clsNodoEnlazado<Tipo> pasarItems()
        {
            return atrSiguiente;
        }
        #endregion

        public void enlazarSiguiente(clsNodoEnlazado<Tipo> nodoSiguiente)
        {
            atrSiguiente = nodoSiguiente;
        }


    }
}
