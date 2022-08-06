using System;
using Servicios.Colecciones.Interfaces;

namespace Servicios.Colecciones.Tads
{
    public class clsTAD<Tipo>:iTAD<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        private Tipo atrItem;
        #endregion
        #region Metodos
        #region Accesores
        public int darLongitud()
        {
            throw new NotImplementedException();
        }
        public Tipo[] darItems()
        {
            throw new NotImplementedException();
        }
        public bool ponerItems(Tipo prmVector)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region QUERY
        public int encontrar(Tipo prmItem)
        {
            throw new NotImplementedException();
        }

        public bool contiene(Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Sorting
        public bool reversar()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region CRUDs
        public bool limpiar()
        {
            throw new NotImplementedException();
        }
        #endregion
        protected bool insertarEn(int indice, Tipo Item)
        {
            throw new NotImplementedException();
        }
        protected bool extraerEn(int indice, Tipo Item)
        {
            throw new NotImplementedException();
        }
        protected bool modificarEn(int indice, Tipo Item)
        {
            throw new NotImplementedException();
        }
        protected bool revisarEn(int indice, Tipo Item)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
