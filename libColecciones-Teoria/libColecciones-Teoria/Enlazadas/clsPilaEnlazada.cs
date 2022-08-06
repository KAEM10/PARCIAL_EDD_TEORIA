using System;
using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Nodos;
using Servicios.Colecciones.Tads;

namespace Servicios.Colecciones.Enlazadas
{
    public class clsPilaEnlazada<Tipo> : clsTADEnlazado<Tipo>, iPila<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        private Tipo[] atrItems;
        private bool atrReversar;
        #endregion
        #region Metodos
        #region accesores
        public override int darLongitud()
        {
            return atrLongitud;
        }
        public override bool estaVacia()
        {
            throw new NotImplementedException();
        }
        public override Tipo[] darItems()
        {
            return atrItems;
        }
        public override clsNodoEnlazado<Tipo> darPrimero()
        {
            return atrPrimero;
        }
        public override clsNodoEnlazado<Tipo> darUltimo()
        {
            return atrUltimo;
        }
        #endregion
        #region Constructores
        public clsPilaEnlazada()
        {
            atrLongitud = 0;
            atrItems = null;
            atrPrimero = null;
            atrUltimo = null;
        }
        #endregion
        #region CRUDs
        public bool apilar(Tipo prmItem)
        {
            bool apilo = false;
            clsNodoEnlazado<Tipo> nodoNuevo = new clsNodoEnlazado<Tipo>(prmItem);
            clsNodoEnlazado<Tipo> nodoTemporal = atrPrimero;
            if (atrPrimero == null)
            {
                atrPrimero = nodoNuevo;
                atrUltimo = nodoNuevo;
            }
            else
            {
                nodoNuevo.enlazarSiguiente(nodoTemporal);
                atrPrimero = nodoNuevo;
            }

            
            atrLongitud++;
            apilo = actualizarAtrItems();
            return apilo;
        }
        public bool desapilar(ref Tipo prmItem)
        {
            bool desapilo = false;
            if(atrLongitud > 0)
            {
                prmItem = atrPrimero.darItem();
                atrPrimero = atrPrimero.pasarItems();
                atrLongitud--;
                desapilo = actualizarAtrItems();
            }
            else
            {
                prmItem = default(Tipo);
            }
            
            return desapilo;
        }
        public bool revisar(ref Tipo prmItem)
        {
            bool reviso = false;
            if(atrLongitud > 0)
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
        public bool actualizarAtrItems() // revisar para items en borde
        {
            bool actualizar = false;
            if(atrLongitud > int.MaxValue / 16)
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
        #region Sorting
        public override bool reversar()
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
        #region Mutadores
        public override bool ponerItems(Tipo[] prmItems) // revisar para items en borde
        {
            bool atrTest = true;
            
            atrItems = prmItems;
            if (prmItems.Length == 0)
            {
                atrTest = false;
            }
            else if(prmItems.Length == int.MaxValue / 16)
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
                        clsNodoEnlazado<Tipo> nodoNuevo = new clsNodoEnlazado<Tipo>(atrItems[i]);
                        
                        if (atrPrimero == null)
                        {
                            atrPrimero = nodoNuevo;
                            atrUltimo = nodoNuevo;
                        }
                        else
                        {
                            nodoNuevo.enlazarSiguiente(atrPrimero);
                            atrPrimero = nodoNuevo;
                        }
                    }
                }
                atrLongitud = atrItems.Length;
            }
            return atrTest;
        }
        #endregion
        #endregion
    }
}
