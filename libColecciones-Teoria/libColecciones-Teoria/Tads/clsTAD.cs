using System;
using Servicios.Colecciones.Interfaces;

namespace Servicios.Colecciones.Tads
{
    public class clsTAD<Tipo> : iTAD<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        private Tipo[] atrItems;
        private int atrLongitud, atrCapacidad, atrFactorCrecimiento = 0;
        private bool atrFlexible, atrReversar;
        #endregion
        #region Metodos
        #region Accesores
        public int darLongitud()
        {
            return atrLongitud;
        }
        public bool estaVacia()
        {
            throw new NotImplementedException();
        }
        public Tipo[] darItems()
        {
            return atrItems;
        }
        public bool ponerItems(Tipo[] prmItems)
        {
            bool atrTest = true;
            atrItems = prmItems;
            if (prmItems.Length == int.MaxValue / 16)
            {
                atrCapacidad = atrItems.Length;
                atrLongitud = atrItems.Length;
                atrFactorCrecimiento = 0;
                atrFlexible = false;
            }
            else if (prmItems.Length == int.MaxValue / 16 + 1)
            {
                atrLongitud = 0;
                atrTest = false;
                atrItems = new Tipo[0];
            }
            atrCapacidad = atrItems.Length;
            atrLongitud = atrItems.Length;
            return atrTest;
        }
        #endregion
        #region QUERY
        public int encontrar(Tipo prmItem)
        {
            int atrIndice = -1;
            if (atrLongitud > 0)
            {
                for (int i = 0; i < atrLongitud; i++)
                {
                    if (atrItems[i].Equals(prmItem))
                    {
                        atrIndice = i;
                        break;
                    }
                }
            }
            return atrIndice;
        }
        public bool contiene(Tipo prmItem)
        {
            bool contiene = false;
            if (atrLongitud > 0)
            {
                for (int i = 0; i < atrLongitud; i++)
                {
                    if (atrItems[i].Equals(prmItem))
                    {
                        contiene = true;
                        break;
                    }
                }
            }
            return contiene;
        }
        #endregion
        #region Sorting
        public bool reversar()
        {
            if (atrLongitud > 0)
            {
                Tipo aux;
                int j = 0;
                int end;
                if (atrLongitud % 2 == 0)
                {
                    end = (atrLongitud) / 2;
                }
                else
                {
                    end = (atrLongitud - 1) / 2;
                }
                for (int i = atrLongitud - 1; i >= end; i--)
                {
                    aux = atrItems[j];
                    atrItems[j] = atrItems[i];
                    atrItems[i] = aux;
                    j++;
                }
                atrReversar = true;
                return atrReversar;
            }
            else
            {
                return atrReversar;
            }
        }
        #endregion
        #region CRUDs
        public bool limpiar()
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
