using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Colecciones.Interfaces;

namespace Servicios.Colecciones.Vectoriales
{
    public class clsColaVector<Tipo> : iCola<Tipo> where Tipo : IComparable<Tipo>
    {
        #region CRUD
        public bool desencolar(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        public bool encolar(Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        public bool revisar(ref Tipo prmItem)
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
