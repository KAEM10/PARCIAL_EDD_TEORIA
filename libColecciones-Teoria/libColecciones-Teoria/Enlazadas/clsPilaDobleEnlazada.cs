using System;
using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Nodos;

namespace Servicios.Colecciones.Enlazadas
{
    public class clsPilaDobleEnlazada<Tipo> : iPila<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        #region Asociativo
        private clsNodoDobleEnlazado<Tipo> atrPrimero;
        private clsNodoDobleEnlazado<Tipo> atrUltimo;
        #endregion
        #endregion
        #region Metodos
        #region CRUD
        public bool apilar(Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        public bool desapilar(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        public bool revisar(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion 
        #endregion
    }
}
