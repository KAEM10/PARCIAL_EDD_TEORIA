using System;
using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Nodos;
namespace Servicios.Colecciones.Tads
{
    public class clsTADDobleEnlazado<Tipo>:clsTAD<Tipo>,iTADDobleEnlazado<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        private clsNodoDobleEnlazado<Tipo> atrPrimero;
        private clsNodoDobleEnlazado<Tipo> atrUltimo;
        #endregion
        #region Metodos
        public clsNodoDobleEnlazado<Tipo> darPrimero()
        {
            throw new NotImplementedException();
        }
        public clsNodoDobleEnlazado<Tipo> darUltimo()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
