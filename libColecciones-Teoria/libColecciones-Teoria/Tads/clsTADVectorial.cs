using System;
using Servicios.Colecciones.Interfaces;

namespace Servicios.Colecciones.Tads
{
    public class clsTADVectorial<Tipo>: clsTAD<Tipo>,iTADVectorial<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        protected int atrCapacidad = 0, atrFactorCrecimiento = 1000;
        protected bool atrFlexible = true, atrFlexibilidad, atrAjustarFC, atrReversar;
        protected Tipo[] atrItems;
        protected int[] testItems;
        #endregion
        #region Metodos
        #region Accesores
        public virtual bool ajustarFlexibilidad(bool prmFlexibilidad)
        {
            throw new NotImplementedException();
        }
        public virtual int darCapacidad()
        {
            throw new NotImplementedException();
        }
        public virtual int darFactorCrecimiento()
        {
            throw new NotImplementedException();
        }
        public virtual bool esFlexible()
        {
            throw new NotImplementedException();
        }
        public virtual bool ponerCapacidad(int prmValor)
        {
            throw new NotImplementedException();
        }
        public virtual bool ponerFactorCrecimiento(int prmFactorCre)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}
