using System;
using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Nodos;

namespace Servicios.Colecciones.Enlazadas
{
    public class clsPilaEnlazada<Tipo> : iPila<Tipo> where Tipo : IComparable<Tipo>
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
        public Tipo[] darItems()
        {
            return atrItems;
        }
        public int darLongitud()
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

            return desapilo;
        }
        public bool revisar(ref Tipo prmItem)
        {
            bool reviso = false;

            return reviso;
        }
        public bool reversar()
        {
            bool reverso = false;

            return reverso;
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
        #region Mutadores

        public bool ponerItems(Tipo[] prmItems) // revisar para items en borde
        {
            bool atrTest = true;
            clsNodoEnlazado<Tipo> nodoTemporal;
            atrItems = prmItems;
            if (prmItems.Length == int.MaxValue / 16 + 1)
            {
                atrTest = false;
                atrItems = new Tipo[0];
            }
            atrLongitud = atrItems.Length;

            for (int i = atrItems.Length - 1; i >= 0; i--)
            {
                if (atrItems[i] != null) { 
                    clsNodoEnlazado<Tipo> nodoNuevo = new clsNodoEnlazado<Tipo>(atrItems[i]);
                    nodoTemporal = atrPrimero;
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
                }
            }



            return atrTest;
        }

        #endregion
        #endregion

    }
}
