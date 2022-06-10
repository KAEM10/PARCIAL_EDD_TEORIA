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
        public bool agregar(Tipo prmItem)
        {
            throw new NotImplementedException();
        }

        public bool contieneA(int prmindice)
        {
            throw new NotImplementedException();
        }

        public bool encontrarA(int prmIndice)
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
    }
}
