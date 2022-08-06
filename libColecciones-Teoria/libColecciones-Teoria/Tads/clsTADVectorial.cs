using System;
using Servicios.Colecciones.Interfaces;

namespace Servicios.Colecciones.Tads
{
    public class clsTADVectorial<Tipo>:clsTAD<Tipo>,iTADVectorial<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        private int atrCapacidad;
        private int atrFactorCrecimiento;
        private bool atrFlexible;
        private Tipo[] atrItems;
        #endregion
        #region Metodos
        #region Accesores
        public bool ajustarFlexibilidad(bool prmValor)
        {
            throw new NotImplementedException();
        }
        public int darCapacidad()
        {
            throw new NotImplementedException();
        }
        public int darFactorCrecimiento()
        {
            throw new NotImplementedException();
        }
        public bool esFlexible()
        {
            throw new NotImplementedException();
        }
        public bool ponerCapacidad(int prmValor)
        {
            throw new NotImplementedException();
        }
        public bool ponerFactorCrecimiento(int prmValor)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}
