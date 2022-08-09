using System;
using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Nodos;
using Servicios.Colecciones.Tads;

namespace Servicios.Colecciones.Enlazadas
{
    public class clsPilaEnlazada<Tipo> : clsTADEnlazado<Tipo>, iPila<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Metodos
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
            return insertarEn(0, prmItem);
        }
        public bool desapilar(ref Tipo prmItem)
        {
            return extraerEn(0, ref prmItem);
        }
        public bool revisar(ref Tipo prmItem)
        {
            return revisarEn(0, ref prmItem);
        }
        #endregion
        #endregion
    }
}
