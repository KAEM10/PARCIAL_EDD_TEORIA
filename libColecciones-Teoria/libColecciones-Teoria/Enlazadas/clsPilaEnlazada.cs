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
            //clsNodoEnlazado<Tipo> nodoTemporal;
            if(atrPrimero == null)
            {
                atrPrimero = nodoNuevo;
                atrUltimo = nodoNuevo;
                apilo = true;
            }
            else
            {
                atrPrimero = nodoNuevo;
                apilo = true;
            }

            //nodoTemporal = atrPrimero;
            //while (nodoTemporal.pasarItems() != null)
            //{
            //    nodoTemporal = nodoTemporal.pasarItems();
            //}
            atrLongitud++;
            actualizarAtrItems();
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

        public void actualizarAtrItems()
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
            }
            else if (prmItems.Length == int.MaxValue / 16 + 1)
            {
                atrItems = null;
                atrLongitud = 0;
                atrTest = false;
            }
            else
            {
                atrLongitud = atrItems.Length;
                for (int i = 0; i < atrItems.Length; i++)
                {
                    clsNodoEnlazado<Tipo> NodoActual = new clsNodoEnlazado<Tipo>();
                    NodoActual.darItem = atrItems[i];
                    if (atrPrimero == null)
                    {
                        atrPrimero = NodoActual;
                        atrUltimo = atrPrimero;
                    }
                    else
                    {
                        atrUltimo.darSiguiente = NodoActual;
                        atrUltimo = atrPrimero;
                    }
                }
                atrFactorCrecimiento = prmFactorCre;
                atrAjustarFC = true;
            }
            else if (prmFactorCre == int.MaxValue / 16)
            {
                atrFactorCrecimiento = 0;
                atrAjustarFC = false;
            }
            else if (prmFactorCre > 0)
            {
                atrFactorCrecimiento = prmFactorCre;
                atrAjustarFC = true;
            }
            return atrTest;
        }
        #endregion
        #endregion
    }
}
