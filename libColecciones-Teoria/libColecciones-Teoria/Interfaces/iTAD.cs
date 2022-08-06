using System;

namespace Servicios.Colecciones.Interfaces
{
    public interface iTAD<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Getters
        int darLongitud();
        Tipo[] darItems();
        #endregion

        #region Setters
        bool ponerItems(Tipo prmVector);
        #endregion

        #region Sorting
        bool reversar();
        #endregion

        #region Crud
        bool limpiar();
        #endregion

        #region QUERY
        int encontrar(Tipo prmItem);
        bool contiene(Tipo prmItem);
        #endregion
    }
}
