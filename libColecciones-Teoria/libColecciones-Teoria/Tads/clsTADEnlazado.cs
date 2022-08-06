using System;
using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Nodos;

namespace Servicios.Colecciones.Tads
{
    public class clsTADEnlazado<Tipo>:clsTAD<Tipo>,iTADEnlazado<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        protected clsNodoEnlazado<Tipo> atrPrimero;
        protected clsNodoEnlazado<Tipo> atrUltimo;
        #endregion
        #region Metodos
        public virtual clsNodoEnlazado<Tipo> darPrimero()
        {
            throw new NotImplementedException();
        }
        public virtual clsNodoEnlazado<Tipo> darUltimo()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
