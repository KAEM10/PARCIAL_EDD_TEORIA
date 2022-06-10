using System;
using Servicios.Colecciones.Interfaces;

namespace Servicios.Colecciones.Enlazadas
{
    public class clsListaEnlazada<Tipo> : iLista<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        #region Asociativos
        private Servicios.Colecciones.Nodos.clsNodoEnlazado<Tipo> atrPrimero;
        private Servicios.Colecciones.Nodos.clsNodoEnlazado<Tipo> atrUltimo;
        #endregion
        #endregion
        #region Metodos
        #region CRUD
        public bool agregar(Tipo prmItem)
        {
            throw new NotImplementedException();
        }

        public bool contieneA(Tipo prmItem)
        {
            throw new NotImplementedException();
        }

        public int encontrarA(Tipo prmItem)
        {
            throw new NotImplementedException();
        }

        public bool extraerEn(int prmIndice, ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }

        public bool insertarEn(int prmIndice, Tipo prmItem)
        {
            throw new NotImplementedException();
        }

        public bool modificarEn(int prmindice, Tipo prmItem)
        {
            throw new NotImplementedException();
        }

        public bool recuperarEn(int prmindice, ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }

        public bool reversar()
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}
