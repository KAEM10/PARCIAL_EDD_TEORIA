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

        bool insertar(int prmIndice, Tipo prmItem);

        bool remover(int prmIndice, ref Tipo prmItem);

        bool modificar(int prmindice, Tipo prmItem);

        #endregion
        #region QUERY
        bool encontrar(Tipo prmItem, ref int prmIndice);
        #endregion
        #endregion
    }
}
