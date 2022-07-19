using System;
using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Nodos;

namespace Servicios.Colecciones.Enlazadas
{
    public class clsListaDobleEnlazada<Tipo> : iLista<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        #region Asociativo
        private clsNodoDobleEnlazado<Tipo> atrPrimero;
        private clsNodoDobleEnlazado<Tipo> atrUltimo;
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
        public clsNodoDobleEnlazado<Tipo> darPrimero()
        {
            return atrPrimero;
        }
        public clsNodoDobleEnlazado<Tipo> darUltimo()
        {
            return atrUltimo;
        }
        #endregion
        #region Constructores
        public clsListaDobleEnlazada()
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
                for (int i = atrItems.Length - 1; i >= 0; i--)
                {
                    if (atrItems[i] != null)
                    {
                        clsNodoDobleEnlazado<Tipo> nodoNuevo = new clsNodoDobleEnlazado<Tipo>(atrItems[i]);

                        if (atrPrimero == null)
                        {
                            atrPrimero = nodoNuevo;
                            atrUltimo = nodoNuevo;
                        }
                        else
                        {
                            nodoNuevo.enlazarSiguiente(atrPrimero);
                            atrPrimero.enlazarAnterior(nodoNuevo);
                            atrPrimero = nodoNuevo;
                        }
                    }
                }
                atrLongitud = atrItems.Length;
            }
            return atrTest;
        }
        #endregion
        #region CRUD
        public bool agregar(Tipo prmItem)
        {
            bool agrego = false;
            clsNodoDobleEnlazado<Tipo> nodoNuevo = new clsNodoDobleEnlazado<Tipo>(prmItem);
            if (atrPrimero == null)
            {
                atrPrimero = nodoNuevo;
                atrUltimo = nodoNuevo;
            }
            else
            {
                atrUltimo.enlazarSiguiente(nodoNuevo);
                nodoNuevo.enlazarAnterior(atrUltimo);
                atrUltimo = nodoNuevo;

            }
            atrLongitud++;
            agrego = actualizarAtrItems();
            return agrego;
        }
        public bool insertar(int prmIndice, Tipo prmItem)
        {
            bool inserto = false;
            clsNodoDobleEnlazado<Tipo> nodoNuevo = new clsNodoDobleEnlazado<Tipo>(prmItem);
            clsNodoDobleEnlazado<Tipo> nodoAuxiliar;

            if (prmIndice >= 0 && prmIndice <= atrLongitud)
            {
                if (prmIndice == 0)
                {
                    if (atrPrimero == null)
                    {
                        atrUltimo = nodoNuevo;
                    }
                    nodoNuevo.enlazarSiguiente(atrPrimero);
                    //atrPrimero.enlazarAnterior(nodoNuevo);
                    atrPrimero = nodoNuevo;
                }
                else if (prmIndice == atrLongitud)
                {
                    atrUltimo.enlazarSiguiente(nodoNuevo);
                    //nodoNuevo.enlazarAnterior(atrUltimo);
                    atrUltimo = nodoNuevo;
                }
                else
                {
                    clsNodoDobleEnlazado<Tipo> nodoTemporal = atrPrimero;

                    for (int i = 0; i < prmIndice - 1; i++)
                    {
                        nodoTemporal = nodoTemporal.pasarItems();
                    }

                    nodoAuxiliar = nodoTemporal.pasarItems();
                    nodoTemporal.enlazarSiguiente(nodoNuevo);
                    nodoNuevo.enlazarSiguiente(nodoAuxiliar);

                }
                atrLongitud++;
                inserto = actualizarAtrItems();
            }
            return inserto;
        }
        public bool extraer(int prmIndice, ref Tipo prmItem)
        {
            bool extraer = false;
            clsNodoDobleEnlazado<Tipo> nodoTemporal = atrPrimero;
            if ((prmIndice >= 0) && (prmIndice < atrLongitud))
            {
                if ((atrLongitud > 0))
                {
                    if (prmIndice == 0)
                    {
                        prmItem = atrPrimero.darItem();
                        atrPrimero = atrPrimero.pasarItems();
                        atrPrimero.enlazarAnterior(null);
                    }
                    else
                    {
                        for (int i = 0; i < prmIndice - 1; i++)
                        {
                            nodoTemporal = nodoTemporal.pasarItems();
                            prmItem = nodoTemporal.pasarItems().darItem();
                        }

                        if (nodoTemporal.pasarItems().pasarItems() == null)
                        {
                            nodoTemporal.enlazarSiguiente(null);
                            atrUltimo = nodoTemporal;
                        }
                        else
                        {
                            nodoTemporal.pasarItems().pasarItems().enlazarAnterior(nodoTemporal);
                            nodoTemporal.enlazarSiguiente(nodoTemporal.pasarItems().pasarItems());
                        }
                    }
                    atrLongitud--;
                    extraer = actualizarAtrItems();
                }
            }
            return extraer;
        }
        public bool modificar(int prmIndice, Tipo prmItem)
        {
            bool modifico = false;
            if (atrLongitud > 0 && prmIndice < atrLongitud && prmIndice >= 0)
            {
                clsNodoDobleEnlazado<Tipo> nodoTemporal = atrPrimero;

                for (int i = 0; i < prmIndice; i++)
                {
                    nodoTemporal = nodoTemporal.pasarItems();
                }
                nodoTemporal.ponerItem(prmItem);
                modifico = actualizarAtrItems();
            }
            return modifico;
        }
        public bool recuperar(int prmIndice, ref Tipo prmItem)
        {
            bool recupero = false;
            if (atrLongitud > 0 && prmIndice < atrLongitud && prmIndice >= 0)
            {
                clsNodoDobleEnlazado<Tipo> nodoTemporal = atrPrimero;
                prmItem = nodoTemporal.darItem();
                for (int i = 0; i < prmIndice; i++)
                {
                    nodoTemporal = nodoTemporal.pasarItems();
                    prmItem = nodoTemporal.darItem();
                }
                recupero = actualizarAtrItems();
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
        public bool actualizarAtrItems()
        {
            bool actualizar = false;
            if (atrLongitud > int.MaxValue / 16)
            {
                atrLongitud--;
                return actualizar;
            }
            atrItems = new Tipo[atrLongitud];
            clsNodoDobleEnlazado<Tipo> nodoTemporal = atrPrimero;
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
            clsNodoDobleEnlazado<Tipo> nodoTemporal = atrPrimero;
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
            clsNodoDobleEnlazado<Tipo> nodoTemporal = atrPrimero;
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
