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
            //atrItems = prmItems;
            //if (prmItems.Length == 0)
            //{
            //    atrTest = false;
            //}
            //else if (prmItems.Length == int.MaxValue / 16)
            //{
            //    atrLongitud = atrItems.Length;
            //}
            //else if (prmItems.Length == int.MaxValue / 16 + 1)
            //{
            //    atrItems = null;
            //    atrLongitud = 0;
            //    atrTest = false;
            //}
            //else
            //{
            //    atrLongitud = atrItems.Length;
            //    for (int i = 0; i < atrItems.Length; i++)
            //    {
            //        clsNodoEnlazado<Tipo> NodoActual = new clsNodoEnlazado<Tipo>();
            //        NodoActual.darItem = atrItems[i];
            //        if (atrPrimero == null)
            //        {
            //            atrPrimero = NodoActual;
            //            atrUltimo = atrPrimero;
            //        }
            //        else
            //        {
            //            atrUltimo.darSiguiente = NodoActual;
            //            atrUltimo = atrPrimero;
            //        }
            //    }
            //}
            return atrTest;
        }
        #endregion
        #region CRUD
        public bool desencolar(ref Tipo prmItem)
        {
            bool desencola = false;
            
            return desencola;
        }
        public bool encolar(Tipo prmItem)
        {
            bool encola = false;
            
            return encola;
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
        #endregion
        #endregion
    }
}
