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
        #region Constructor
        public clsNodoDobleEnlazado()
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

        public clsNodoDobleEnlazado<Tipo> darSiguiente
        {
            get { return atrSiguiente; }
            set { atrSiguiente = value; }
        }

        public clsNodoDobleEnlazado<Tipo> darAnterior
        {
            get { return atrAnterior; }
            set { atrAnterior = value; }
        }
        #endregion
    }
}
