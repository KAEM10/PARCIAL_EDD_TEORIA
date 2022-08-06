using System;
using Servicios.Colecciones.Interfaces;

namespace Servicios.Colecciones.Nodos
{
    public class clsNodoDobleEnlazado<Tipo>:clsNodo<Tipo>,iNodoDobleEnlazado<Tipo> where Tipo:IComparable<Tipo>
    {
        #region Atributos
        #region Asociativo
        private clsNodoDobleEnlazado<Tipo> atrAnterior;
        private clsNodoDobleEnlazado<Tipo> atrSiguiente;
        #endregion
        #endregion
        #region Constructor
        public clsNodoDobleEnlazado(Tipo prmitem)
        {
            this.atrSiguiente = null;
            this.atrItem = prmitem;
        }
        #endregion
        #region Metodos
        public clsNodoDobleEnlazado<Tipo> pasarItems()
        {
            return atrSiguiente;
        }

        public void enlazarSiguiente(clsNodoDobleEnlazado<Tipo> nodoSiguiente)
        {
            atrSiguiente = nodoSiguiente;
        }

        public void enlazarAnterior(clsNodoDobleEnlazado<Tipo> nodoAnterior)
        {
            atrAnterior = nodoAnterior;
        }

        public clsNodoDobleEnlazado<Tipo> darSiguiente()
        {
            throw new NotImplementedException();
        }

        public clsNodoDobleEnlazado<Tipo> darAnterior()
        {
            throw new NotImplementedException();
        }

        public bool ponerSiguiente()
        {
            throw new NotImplementedException();
        }

        public bool ponerAnterior()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
