using System;

namespace Servicios.Colecciones.Interfaces
{
    public interface iTADVectorial<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Getters
        int darFactorCrecimiento();
        int darCapacidad();
        #endregion
        #region Setters
        bool ponerCapacidad(int prmValor);
        bool ponerFactorCrecimiento(int prmValor);
        bool ajustarFlexibilidad(bool prmFlexibilidad);
        #endregion
        #region QUERY
        bool esFlexible();
        #endregion
    }
}
