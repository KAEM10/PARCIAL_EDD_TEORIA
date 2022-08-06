using System;

namespace Servicios.Colecciones.Interfaces
{
    public interface iNodo<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Getters
        Tipo darItem();
        #endregion

        #region Setters
        bool ponerItem(Tipo Item);
        #endregion
    }
}
