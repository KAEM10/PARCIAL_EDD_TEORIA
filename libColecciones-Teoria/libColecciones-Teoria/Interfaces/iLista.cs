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

        bool extraer(int prmIndice, ref Tipo prmItem);

        bool modificar(int prmindice, Tipo prmItem);

        bool recuperar(int prmindice, ref Tipo prmItem);

        bool reversar();

        #endregion
        #region QUERY
        int encontrar(Tipo prmItem);

        bool contiene(Tipo prmItem);
        #endregion
        #endregion
    }
}
