using System;
using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Nodos;
namespace Servicios.Colecciones.Tads
{
    public class clsTADDobleEnlazado<Tipo>:clsTAD<Tipo>,iTADDobleEnlazado<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        protected clsNodoDobleEnlazado<Tipo> atrPrimero;
        protected clsNodoDobleEnlazado<Tipo> atrUltimo;
        #endregion
        #region Metodos
        #region Accesores
        public virtual clsNodoDobleEnlazado<Tipo> darPrimero()
        {
            return atrPrimero;
        }
        public virtual clsNodoDobleEnlazado<Tipo> darUltimo()
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
        #region CRUDs
        public override bool insertarEn(int prmIndice, Tipo prmItem)
        {
            bool inserto = false;
            clsNodoDobleEnlazado<Tipo> nodoNuevo = new clsNodoDobleEnlazado<Tipo>(prmItem);
            clsNodoDobleEnlazado<Tipo> nodoAuxiliar;
            if (atrLongitud + 1 < int.MaxValue / 16)
            {
                if (prmIndice >= 0 && prmIndice <= atrLongitud)
                {
                    if (prmIndice == 0)
                    {
                        if (atrLongitud == 0)
                        {
                            atrPrimero = nodoNuevo;
                            atrUltimo = nodoNuevo;
                        }
                        else
                        {
                            atrPrimero.enlazarAnterior(nodoNuevo);
                            nodoNuevo.enlazarSiguiente(atrPrimero);
                            atrPrimero = nodoNuevo;
                        }
                    }
                    else if (prmIndice == atrLongitud)
                    {
                        nodoNuevo.enlazarAnterior(atrUltimo);
                        atrUltimo.enlazarSiguiente(nodoNuevo);
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
                        nodoAuxiliar.enlazarAnterior(nodoNuevo);
                        nodoNuevo.enlazarSiguiente(nodoAuxiliar);
                        nodoNuevo.enlazarAnterior(nodoTemporal);


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
                            nodoTemporal.enlazarAnterior(atrUltimo);
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
        public override bool revisarEn(int prmIndice, ref Tipo prmItem)
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
            else
            {
                prmItem = default(Tipo);
            }
            return recupero;
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
        public override int encontrar(Tipo prmItem)
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
        public override bool contiene(Tipo prmItem)
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
