using System;
using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Nodos;
using Servicios.Colecciones.Tads;

namespace Servicios.Colecciones.Enlazadas
{
    public class clsListaEnlazada<Tipo> : clsTADEnlazado<Tipo>, iLista<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Metodos
        #region Constructores
        public clsListaEnlazada()
        {
            atrLongitud = 0;
            atrItems = null;
            atrPrimero = null;
            atrUltimo = null;
        }
        #endregion
        #region CRUD
        public bool agregar(Tipo prmItem)
        {
            
            return insertarEn(atrLongitud,prmItem);
        }
        public bool insertar(int prmIndice, Tipo prmItem)
        {
            return insertarEn(prmIndice, prmItem);
        }
        public bool extraer(int prmIndice, ref Tipo prmItem)
        {
            return extraerEn(prmIndice, ref prmItem);
        }
        public bool modificar(int prmIndice, Tipo prmItem)
        {
            return modificarEn(prmIndice, prmItem);
        }
        public bool recuperar(int prmIndice, ref Tipo prmItem)
        {
            return revisarEn(prmIndice, ref prmItem);
        }
        #endregion
        #endregion
    }
}
