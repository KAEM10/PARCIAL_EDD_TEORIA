using System;
using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Nodos;

namespace Servicios.Colecciones.Enlazadas
{
    public class clsListaEnlazada<Tipo> : iLista<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        #region Asociativo
        private clsNodoEnlazado<Tipo> atrPrimero;
        private clsNodoEnlazado<Tipo> atrUltimo;
        #endregion
        private Tipo[] atrItems;
        private int atrLongitud;
        private bool atrReversar;
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
        public clsListaEnlazada()
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
        public bool agregar(Tipo prmItem)
        {
            bool agrego = false;
            clsNodoEnlazado<Tipo> nodoNuevo = new clsNodoEnlazado<Tipo>(prmItem);
            if(atrPrimero == null)
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
            agrego = actualizarAtrItems();
            return agrego;
        }
        public bool insertar(int prmIndice, Tipo prmItem)
        {
            bool inserto = false;
            return inserto;
        }
        public bool extraer(int prmIndice, ref Tipo prmItem)
        {
            bool extraer = false;
            clsNodoEnlazado<Tipo> nodoTemporal = atrPrimero;

            if ((prmIndice >= 0) && (prmIndice < atrLongitud))
            {
                if ((atrLongitud > 0))
                {
                    if(prmIndice == 0)
                    {

                    }
                    extraer = true;
                    atrLongitud--;
                }

            }
            actualizarAtrItems();
            return extraer;
        }
        public bool modificar(int prmIndice, Tipo prmItem)
        {
            bool modifico = false;
            if ((prmIndice >= 0) && (prmIndice < atrLongitud))
            {
                atrItems[prmIndice] = prmItem;
                modifico = true;
            }

            return modifico;
        }
        public bool recuperar(int prmIndice, ref Tipo prmItem)
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
        #region QUERY
        public int encontrar(Tipo prmItem)
        {
            int atrIndice = -1;
            clsNodoEnlazado<Tipo> nodoTemporal = atrPrimero;
            if (atrLongitud > 0)
            {
                for (int i = 0; i < atrLongitud; i++)
                {
                    if (nodoTemporal.darItem().Equals(prmItem))
                    {
                        atrIndice = i;
                        break;
                    }
                    else
                    {
                        nodoTemporal = nodoTemporal.pasarItems();
                    }
                }
            }

            return atrIndice;
        }
        public bool contiene(Tipo prmItem)
        {
            bool contiene = false;
            clsNodoEnlazado<Tipo> nodoTemporal = atrPrimero;
            if (atrLongitud > 0)
            {
                for (int i = 0; i < atrLongitud; i++)
                {
                    if (nodoTemporal.darItem().Equals(prmItem))
                    {
                        contiene = true;
                        break;
                    }
                    else
                    {
                        nodoTemporal = nodoTemporal.pasarItems();
                    }
                }
            }

            return contiene;
        }
        #endregion
        #endregion
    }
}
