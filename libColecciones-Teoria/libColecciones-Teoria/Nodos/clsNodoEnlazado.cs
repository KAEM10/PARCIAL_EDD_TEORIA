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
        #region Constructor
        public clsNodoEnlazado()
        {
            atrItem = default(Tipo);
            atrSiguiente = null;
        }
        #endregion
        #region Metodos
        public Tipo darItem
        {
            get { return atrItem; }
            set { atrItem = value; }
        }

        public clsNodoEnlazado<Tipo> darSiguiente
        {
            get { return atrSiguiente; }
            set { atrSiguiente = value; }
        }
        #endregion

        public void enlazarSiguiente(clsNodoEnlazado<Tipo> nodoSiguiente)
        {
            atrSiguiente = nodoSiguiente;
        }

        
    }
}
