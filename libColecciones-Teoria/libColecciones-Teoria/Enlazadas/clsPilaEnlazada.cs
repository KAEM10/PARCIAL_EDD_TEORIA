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
        private int atrCapacidad;
        private int atrLongitud;
        private bool atrDinamica;
        private int atrFactorCrecimiento;
        private bool atrAjustarFC;
        private bool atrFlexibilidad;
        private bool atrReversar;
        private int[] testItems;
        
        #endregion
        #region Metodos
        #region Accesores
        public Tipo[] darItems() //metodo para accceder al arreglo
        {
            return atrItems;
        }
        public int darCapacidad() //metodo para acceder a la capacidad
        {
            return atrCapacidad;
        }
        public int darLongitud() //metodo para acceder a la longitud
        {
            return atrLongitud;
        }
        public bool esFlexible()// metodo para saber si es flexible
        {
            return atrDinamica;
        }
        public int darFactorCrecimiento() // metodo para acceder a el factorcrecimiento
        {
            return atrFactorCrecimiento;
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
            if (atrCapacidad == 0)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = null;
            }
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
            atrItems = new Tipo[atrLongitud];
            clsNodoEnlazado<Tipo> nodoTemporal = atrPrimero;
            for(int i = 0; i < atrLongitud; i++)
            {
                atrItems[i] = nodoTemporal.darItem();
                if(nodoTemporal.pasarItems() != null)
                {
                    nodoTemporal = nodoTemporal.pasarItems();
                }
            }

        }

        #endregion
        #region Mutadores
        public bool ponerItems(Tipo[] prmItems)
        {
            bool atrTest = true;
            
            return atrTest;
        }
        public bool ajustarFlexibilidad(bool prmFlexibilidad)
        {
            if (prmFlexibilidad == false && atrCapacidad > 0)
            {
                atrFlexibilidad = true;
                atrDinamica = false;
                atrFactorCrecimiento = 0;
            }
            else if (prmFlexibilidad == false && atrCapacidad == 0)
            {
                atrFlexibilidad = false;
            }
            else
            {
                atrFlexibilidad = false;
            }
            return atrFlexibilidad;
        }
        public bool ajustarFactorCrecimiento(int prmFactorCre)
        {
            if (prmFactorCre == int.MaxValue / 16 - atrItems.Length)
            {
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

            return atrAjustarFC;
        }
        #endregion
        #endregion
    }
}
