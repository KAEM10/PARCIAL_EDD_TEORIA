using System;
using Servicios.Colecciones.Interfaces;

namespace Servicios.Colecciones.Tads
{
    public class clsTAD<Tipo> : iTAD<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        protected int atrLongitud;
        
        protected Tipo[] atrItems;
        #endregion
        #region Metodos
        #region Accesores
        public virtual int darLongitud()
        {
            return atrLongitud;
        }
        public virtual bool estaVacia()
        {
            bool vacio = atrLongitud == 0 ? true : false;
            return vacio;
        }
        public virtual Tipo[] darItems()
        {
            return atrItems;
        }
        public virtual bool ponerItems(Tipo[] prmItems)
        {
            bool atrTest = true;

            atrItems = prmItems;
            if (prmItems.Length == 0)
            {
                atrTest = false;
            }
            else if (prmItems.Length == int.MaxValue / 16)
            {
                atrLongitud = atrItems.Length;
                return atrTest;
            }
            else if (prmItems.Length == int.MaxValue / 16 + 1)
            {
                atrLongitud = 0;
                atrTest = false;
                atrItems = new Tipo[0];
                atrItems = default(Tipo[]);
            }
            atrLongitud = atrItems.Length;
            
            return atrTest;
        }
        #endregion
        #region QUERY
        public virtual int encontrar(Tipo prmItem)
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
        public virtual bool contiene(Tipo prmItem)
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
        public virtual bool reversar()
        {
            bool reversar = false;
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
                reversar = true;
                return reversar;
            }
            else
            {
                return reversar;
            }
        }
        #endregion
        #region CRUDs
        public virtual bool limpiar()
        {
            throw new NotImplementedException();
        }
        public virtual bool insertarEn(int prmIndice, Tipo prmItem)
        {
            bool inserto = false;//Sobre escrito en las 3 categorias
            return inserto;
        }
        public virtual bool extraerEn(int prmIndice, ref Tipo prmItem)
        {
            bool extraer = false;

            if ((prmIndice >= 0) && (prmIndice < atrLongitud))
            {
                if ((atrLongitud > 0) && (atrItems[prmIndice] != null))
                {
                    prmItem = atrItems[prmIndice];
                    for (int i = prmIndice; i < (atrLongitud - 1); i++)
                    {
                        atrItems[i] = atrItems[i + 1];
                    }
                    extraer = true;
                    atrLongitud--;
                }

            }

            return extraer;
        }
        public virtual bool modificarEn(int prmIndice, Tipo prmItem)
        {
            bool modifico = false;
            if ((prmIndice >= 0) && (prmIndice < atrLongitud))
            {
                atrItems[prmIndice] = prmItem;
                modifico = true;
            }

            return modifico;
        }
        public virtual bool revisarEn(int prmIndice, ref Tipo prmItem)
        {
            bool recupero = false;
            if ((prmIndice >= 0) && (prmIndice < atrLongitud))
            {
                prmItem = atrItems[prmIndice];
                recupero = true;
            }
            else
            {
                prmItem = default(Tipo);
            }


            return recupero;
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
        
    }
    #endregion
    #endregion
}
