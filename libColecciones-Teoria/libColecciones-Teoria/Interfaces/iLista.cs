using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Colecciones.Interfaces
{
    public interface iLista<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Metodos
        #region CRUD
        bool agregar(Tipo prmItem);

        bool insertarEn(int prmIndice, Tipo prmItem);

        bool extraerEn(int prmIndice, ref Tipo prmItem);

        bool modificarEn(int prmindice, Tipo prmItem);

        #endregion
        #region QUERY
        bool encontrarA(Tipo prmItem, ref int prmIndice);
        #endregion
        #endregion
    }
}
