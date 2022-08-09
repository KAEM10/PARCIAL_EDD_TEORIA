using System;
using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Nodos;

namespace Servicios.Colecciones.Tads
{
    public class clsTADEnlazado<Tipo>:clsTAD<Tipo>,iTADEnlazado<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        protected clsNodoEnlazado<Tipo> atrPrimero;
        protected clsNodoEnlazado<Tipo> atrUltimo;
        #endregion
        #region Metodos
        #region Accesores
        public virtual clsNodoEnlazado<Tipo> darPrimero()
        {
            return atrPrimero;
        }
        public virtual clsNodoEnlazado<Tipo> darUltimo()
        {
            return atrUltimo;
        }
        #endregion
        #region Mutadores
        public override bool ponerItems(Tipo[] prmItems)
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
        #region CRUDs
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

        public override bool insertarEn(int prmIndice, Tipo prmItem)
        {
            bool inserto = false;
            clsNodoEnlazado<Tipo> nodoNuevo = new clsNodoEnlazado<Tipo>(prmItem);
            clsNodoEnlazado<Tipo> nodoAuxiliar;
            if (atrLongitud + 1 < int.MaxValue / 16)
            {
                if (prmIndice >= 0 && prmIndice <= atrLongitud)
                {
                    if (prmIndice == 0)
                    {
                        if (atrPrimero == null)
                        {
                            atrUltimo = nodoNuevo;
                        }
                        nodoNuevo.enlazarSiguiente(atrPrimero);
                        atrPrimero = nodoNuevo;

                    }
                    else if (prmIndice == atrLongitud)
                    {
                        atrUltimo.enlazarSiguiente(nodoNuevo);
                        atrUltimo = nodoNuevo;
                    }
                    else
                    {
                        clsNodoEnlazado<Tipo> nodoTemporal = atrPrimero;

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
            }
            return inserto;
        }
        public override bool extraerEn(int prmIndice, ref Tipo prmItem)
        {
            bool extraer = false;
            clsNodoEnlazado<Tipo> nodoTemporal = atrPrimero;

            if ((prmIndice >= 0) && (prmIndice < atrLongitud))
            {
                if ((atrLongitud > 0))
                {
                    if (prmIndice == 0)
                    {
                        prmItem = atrPrimero.darItem();
                        atrPrimero = atrPrimero.pasarItems();
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
                            nodoTemporal.enlazarSiguiente(nodoTemporal.pasarItems().pasarItems());
                        }
                    }
                    atrLongitud--;
                    extraer = actualizarAtrItems();
                }
            }
            else
            {
                prmItem = default(Tipo);
            }
            return extraer;
        }
        public override bool modificarEn(int prmIndice, Tipo prmItem)
        {
            bool modifico = false;

            if (atrLongitud > 0 && prmIndice < atrLongitud && prmIndice >= 0)
            {
                clsNodoEnlazado<Tipo> nodoTemporal = atrPrimero;

                for (int i = 0; i < prmIndice; i++)
                {
                    nodoTemporal = nodoTemporal.pasarItems();
                }
                nodoTemporal.ponerItem(prmItem);
                modifico = actualizarAtrItems();
            }
            return modifico;
        }
        public override bool revisarEn(int prmIndice, ref Tipo prmItem)
        {
            bool recupero = false;
            if (atrLongitud > 0 && prmIndice < atrLongitud && prmIndice >= 0)
            {
                clsNodoEnlazado<Tipo> nodoTemporal = atrPrimero;
                prmItem = nodoTemporal.darItem();
                for (int i = 0; i < prmIndice; i++)
                {
                    nodoTemporal = nodoTemporal.pasarItems();
                    prmItem = nodoTemporal.darItem();
                }
                recupero = actualizarAtrItems();
            }
            else
            {
                prmItem = default(Tipo);
            }
            return recupero;
        }


        #endregion
        #region QUERY
        public override int encontrar(Tipo prmItem)
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
        public override bool contiene(Tipo prmItem)
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
