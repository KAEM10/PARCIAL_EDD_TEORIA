using System;
using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Nodos;

namespace Servicios.Colecciones.Tads
{
    public class clsTADEnlazado<Tipo>:clsTAD<Tipo>,iTADEnlazado<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        private clsNodoEnlazado<Tipo> atrPrimero;
        private clsNodoEnlazado<Tipo> atrUltimo;
        #endregion
        #region Metodos
        public clsNodoEnlazado<Tipo> darPrimero()
        {
            throw new NotImplementedException();
        }
        public clsNodoEnlazado<Tipo> darUltimo()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
