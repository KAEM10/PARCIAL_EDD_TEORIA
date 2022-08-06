using System;
using Servicios.Colecciones.Interfaces;

namespace Servicios.Colecciones.Tads
{
    public class clsTAD<Tipo> : iTAD<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        protected int atrLongitud;
        #endregion
        #region Metodos
        #region Accesores
        public virtual int darLongitud()
        {
            throw new NotImplementedException();
        }
        public virtual bool estaVacia()
        {
            throw new NotImplementedException();
        }
        public virtual Tipo[] darItems()
        {
            throw new NotImplementedException();
        }
        public virtual bool ponerItems(Tipo[] prmItems)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region QUERY
        public virtual int encontrar(Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        public virtual bool contiene(Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Sorting
        public virtual bool reversar()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region CRUDs
        public virtual bool limpiar()
        {
            throw new NotImplementedException();
        }
        #region Patron Iterador
        #region Atributos
        protected int atrIndiceActual;//EN QUE LUGAR SE ENCUENTRA UBICADO EL ITERADOR 0 Y LONGITUD-1
        protected Tipo atrItemActual;//contiene la posicion actual
        #endregion
        #region Operaciones
        #region Accesores
        public int darIndiceActual()
        {
            return atrIndiceActual;
        }
        public Tipo darItemActual()
        {
            return atrItemActual;
        }
        #endregion
        #region Mutadores
        public virtual void ponerItemActual(Tipo prmItem) { }
        #endregion
        #region Posicionadores
        public virtual bool irPrimero()
        {
            return false;
        }
        public virtual bool irUltimo()
        {
            return false;
        }
        public bool irAnterior()
        {
            if (hayAnterior())
                return retrocederItem();
            return false;
        }
        public bool irSiguiente()
        {
            if (haySiguiente())
                return avanzarItem();
            return false;
        }
        public virtual bool irIndice(int prmIndice)
        {
            if (prmIndice == 0)
                return irPrimero();
            if (prmIndice == atrLongitud - 1)
                return irUltimo();
            if (esValido(prmIndice))
            {
                irPrimero();
                while (atrIndiceActual < prmIndice)
                    irSiguiente();
                return true;


            }
            return false;
        }

        private bool esValido(int prmIndice)
        {
            throw new NotImplementedException();
        }

        protected virtual bool avanzarItem()
        {
            return false;
        }
        protected virtual bool retrocederItem()
        {
            return false;
        }

        #endregion
        #region Consultores
        public bool hayAnterior()
        {
            return (estaVacia() == false && atrIndiceActual > 0);
        }
        public bool haySiguiente()
        {
            return (estaVacia() == false && atrIndiceActual < atrLongitud - 1);
        }
        #endregion
        #endregion
        #endregion
        protected bool insertarEn(int indice, Tipo Item)
        {
            throw new NotImplementedException();
        }
        protected bool extraerEn(int indice, Tipo Item)
        {
            throw new NotImplementedException();
        }
        protected bool modificarEn(int indice, Tipo Item)
        {
            throw new NotImplementedException();
        }
        protected bool revisarEn(int indice, Tipo Item)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
    #endregion
}
