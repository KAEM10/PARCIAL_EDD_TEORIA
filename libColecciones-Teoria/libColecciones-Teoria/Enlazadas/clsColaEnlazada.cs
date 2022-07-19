using System;
using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Nodos;

namespace Servicios.Colecciones.Enlazadas
{
    public class clsColaEnlazada<Tipo> : iCola<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        #region Asociativo
        private clsNodoEnlazado<Tipo> atrPrimero;
        private clsNodoEnlazado<Tipo> atrUltimo;
        #endregion
        private Tipo[] atrItems;
        private int atrLongitud;
        #endregion
        #region Metodos
        #region Accesores
        public Tipo[] darItems() //metodo para accceder al arreglo
        {
            return atrItems;
        }
        public int darLongitud() //metodo para acceder a la longitud
        {
            return atrLongitud;
        }
        public clsNodoEnlazado<Tipo> darPrimero()
        {
            return atrPrimero;
        }
        public clsNodoEnlazado<Tipo> darUltimo()
        {
            return atrUltimo;
        }
        #endregion
        #region Constructores
        public clsColaEnlazada()
        {
            atrLongitud = 0;
            atrItems = null;
            atrPrimero = null;
            atrUltimo = null;
        }
        #endregion
        #region Mutadores
        public bool ponerItems(Tipo[] prmItems)
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
            else
            {
                atrLongitud = atrItems.Length;
                for (int i = 0; i < atrLongitud; i++)
                {
                    if (atrItems[i] != null)
                    {
                        clsNodoEnlazado<Tipo> nodoNuevo = new clsNodoEnlazado<Tipo>(atrItems[i]);
                        
                        if (atrPrimero == null)
                        {
                            atrPrimero = nodoNuevo;
                            atrUltimo = nodoNuevo;
                        }
                        else
                        {
                            atrUltimo.enlazarSiguiente(nodoNuevo);
                            atrUltimo = nodoNuevo;
                        }
                    }
                }
                
            }
            return atrTest;
        }
        #endregion
        #region CRUD
        public bool desencolar(ref Tipo prmItem)
        {
            bool desencola = false;
            if(atrLongitud > 0)
            {
                prmItem = atrPrimero.darItem();
                atrPrimero = atrPrimero.pasarItems();
                atrLongitud--;
                desencola = actualizarAtrItems();
            }
            else
            {
                prmItem = default(Tipo);
            }
            return desencola;
        }
        public bool encolar(Tipo prmItem)
        {
            bool encola = false;
            clsNodoEnlazado<Tipo> nodoNuevo = new clsNodoEnlazado<Tipo>(prmItem);
            if (atrPrimero == null)
            {
                atrPrimero = nodoNuevo;
                atrUltimo = nodoNuevo;
            }
            else
            {
                atrUltimo.enlazarSiguiente(nodoNuevo);
                atrUltimo = nodoNuevo;
            }
            atrLongitud++;
            encola = actualizarAtrItems();
            return encola;
        }
        public bool revisar(ref Tipo prmItem)
        {
            bool reviso = false;
            if (atrLongitud > 0)
            {
                prmItem = atrPrimero.darItem();
                reviso = true;
            }
            else
            {
                prmItem = default(Tipo);
            }
            return reviso;
        }
        public bool reversar()
        {
            bool atrReversar = false;
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
                atrPrimero = null;
                atrUltimo = null;
                ponerItems(atrItems);
                return atrReversar;
            }
            else
            {
                return atrReversar;
            }
        }

        public bool actualizarAtrItems() // revisar para items en borde
        {
            bool actualizar = false;
            if (atrLongitud > int.MaxValue / 16)
            {
                atrLongitud--;
                return actualizar;
            }
            atrItems = new Tipo[atrLongitud];
            clsNodoEnlazado<Tipo> nodoTemporal = atrPrimero;
            for (int i = 0; i < atrLongitud; i++)
            {
                atrItems[i] = nodoTemporal.darItem();
                if (nodoTemporal.pasarItems() != null)
                {
                    nodoTemporal = nodoTemporal.pasarItems();
                }
            }
            actualizar = true;
            return actualizar;
        }
        #endregion
        #endregion
    }
}
