using System;
using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Nodos;
using Servicios.Colecciones.Tads;

namespace Servicios.Colecciones.Enlazadas
{
    public class clsColaDobleEnlazada<Tipo> : clsTADDobleEnlazado<Tipo>, iCola<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Metodos
        #region Constructores
        public clsColaDobleEnlazada()
        {
            atrLongitud = 0;
            atrItems = null;
            atrPrimero = null;
            atrUltimo = null;
        }
        #endregion
        #region CRUD
        public bool desencolar(ref Tipo prmItem)
        {
            return extraerEn(0, ref prmItem);
        }
        public bool encolar(Tipo prmItem)
        {
            return insertarEn(atrLongitud, prmItem);
        }
        public bool revisar(ref Tipo prmItem)
        {
            return revisarEn(0, ref prmItem);
        }
        #endregion
        #endregion
    }
}
