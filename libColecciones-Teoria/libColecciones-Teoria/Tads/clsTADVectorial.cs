using System;
using Servicios.Colecciones.Interfaces;

namespace Servicios.Colecciones.Tads
{
    public class clsTADVectorial<Tipo>: clsTAD<Tipo>,iTADVectorial<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        private int atrCapacidad;
        private int atrFactorCrecimiento;
        private bool atrFlexible;
        private Tipo[] atrItems;
        #endregion
        #region Metodos
        #region Accesores
        public bool ajustarFlexibilidad(bool prmFlexibilidad)
        {
            bool atrFlexibilidad;
            if (prmFlexibilidad == false && atrCapacidad > 0)
            {
                atrFlexibilidad = true;
                atrFlexible = false;
                atrFactorCrecimiento = 0;
            }
            else if (prmFlexibilidad == false && atrCapacidad == 0)
            {
                atrFlexibilidad = false;
            }
            else
            {
                atrFlexibilidad = false;
            }
            return atrFlexibilidad;
        }
        public int darCapacidad()
        {
            return atrCapacidad;
        }
        public int darFactorCrecimiento()
        {
            return atrFactorCrecimiento;
        }
        public bool esFlexible()
        {
            return atrFlexible;
        }
        public bool ponerCapacidad(int prmValor)
        {
            throw new NotImplementedException();
        }
        public bool ponerFactorCrecimiento(int prmFactorCre)
        {
            bool atrAjustarFC = false;
            if (prmFactorCre == int.MaxValue / 16 - atrItems.Length)
            {
                atrFactorCrecimiento = prmFactorCre;
                atrAjustarFC = true;
            }
            else if (prmFactorCre == int.MaxValue / 16)
            {
                atrFactorCrecimiento = 0;
                atrAjustarFC = false;
            }
            else if (prmFactorCre > 0)
            {
                atrFactorCrecimiento = prmFactorCre;
                atrAjustarFC = true;
            }
            return atrAjustarFC;
        }
        #endregion
        #endregion
    }
}
