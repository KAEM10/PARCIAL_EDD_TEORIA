using System;
using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Nodos;
namespace Servicios.Colecciones.Tads
{
    public class clsTADDobleEnlazado<Tipo>:clsTAD<Tipo>,iTADDobleEnlazado<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        protected clsNodoDobleEnlazado<Tipo> atrPrimero;
        protected clsNodoDobleEnlazado<Tipo> atrUltimo;
        #endregion
        #region Metodos
        public virtual clsNodoDobleEnlazado<Tipo> darPrimero()
        {
            throw new NotImplementedException();
        }
        public virtual clsNodoDobleEnlazado<Tipo> darUltimo()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
