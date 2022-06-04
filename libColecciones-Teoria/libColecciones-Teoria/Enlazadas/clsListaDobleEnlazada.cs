using System;
using Servicios.Colecciones.Interfaces;

namespace Servicios.Colecciones.Enlazadas
{
    public class clsListaDobleEnlazada<Tipo> : iLista<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        #region Asociativos
        private Servicios.Colecciones.Nodos.clsNodoDobleEnlazado<Tipo> atrPrimero;
        private Servicios.Colecciones.Nodos.clsNodoDobleEnlazado<Tipo> atrUltimo;
        #endregion
        #endregion
        #region Metodos
        #region CRUD
        public bool agregar(Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        public bool insertarEn(int prmIndice, Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        public bool extraerEn(int prmIndice, ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        public bool modificarEn(int prmindice, Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region QUERY
        public bool encontrarA(Tipo prmItem, ref int prmIndice)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}
