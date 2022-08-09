using System;
using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Tads;

namespace Servicios.Colecciones.Vectoriales
{
    public class clsColaVector<Tipo> : clsTADVectorial<Tipo>, iCola<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Metodos
        #region Constructores
        public clsColaVector()
        {
            testItems = new Tipo[0];
            if (atrCapacidad == 0)
            {
                atrItems = new Tipo[atrCapacidad];
            }
        }
        public clsColaVector(int prmCapacidad)
        {
            if ((prmCapacidad < 0) || (prmCapacidad == int.MaxValue / 16 + 1)|| (prmCapacidad == int.MaxValue))
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue / 16)
            {
                atrCapacidad = int.MaxValue / 16;
                atrItems = new Tipo[int.MaxValue / 16];
                atrFactorCrecimiento = 0;
                atrFlexible = false;
            }
            else
            {
                atrCapacidad = prmCapacidad;
                atrItems = new Tipo[atrCapacidad];
            }
        }
        public clsColaVector(int prmCapacidad, bool prmDinamica)
        {
            if ((prmCapacidad < 0 && prmDinamica == true)|| (prmCapacidad < 0 && prmDinamica == false)|| (prmCapacidad == int.MaxValue / 16 + 1 && prmDinamica == true))
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if ((prmCapacidad == int.MaxValue / 16 + 1 && prmDinamica == false)|| (prmCapacidad == int.MaxValue && prmDinamica == true)|| (prmCapacidad == int.MaxValue && prmDinamica == false))
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad > 0 && prmDinamica == false)
            {
                atrCapacidad = prmCapacidad;
                atrFactorCrecimiento = 0;
                atrFlexible = false;
                atrItems = new Tipo[atrCapacidad];
            }
            else
            {
                atrCapacidad = prmCapacidad;
                atrItems = new Tipo[atrCapacidad];
            }
        }
        public clsColaVector(int prmCapacidad, int prmFactor)
        {
            if ((prmCapacidad < 0 && prmFactor < 0)|| (prmCapacidad < 0 && prmFactor > 0)|| (prmCapacidad > 0 && prmFactor < 0)|| (prmCapacidad == 0 && prmFactor == 0)|| (prmCapacidad < 0 && prmFactor == 0)|| (prmCapacidad == int.MaxValue / 16 && prmFactor < 0))
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if ((prmCapacidad == int.MaxValue && prmFactor == int.MaxValue / 16 + 1) || (prmCapacidad == int.MaxValue && prmFactor == 0)|| (prmCapacidad == int.MaxValue && prmFactor < 0)|| (prmCapacidad == int.MaxValue && prmFactor > 0))
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue / 16 && prmFactor == 0)
            {
                atrCapacidad = int.MaxValue / 16;
                atrFactorCrecimiento = 0;
                atrFlexible = false;
                atrItems = new Tipo[atrCapacidad];
            }
            else if ((prmCapacidad == int.MaxValue / 16 && prmFactor > 0)|| (prmCapacidad == int.MaxValue / 16 && prmFactor == int.MaxValue / 16 + 1)|| (prmCapacidad == int.MaxValue / 16 + 1 && prmFactor < 0)|| (prmCapacidad == int.MaxValue / 16 + 1 && prmFactor == 0))
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue / 16 + 1 && prmFactor > 0)
            {
                atrFlexible = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if ((prmCapacidad == int.MaxValue / 16 + 1 && prmFactor == int.MaxValue / 16 + 1)|| (prmCapacidad < 0 && prmFactor == int.MaxValue / 16 + 1)|| (prmCapacidad == 0 && prmFactor == int.MaxValue / 16 + 1)|| (prmCapacidad > 0 && prmFactor == int.MaxValue / 16 + 1)|| (prmCapacidad == 0 && prmFactor < 0))
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == 0 && prmFactor > 0)
            {
                atrFactorCrecimiento = 500;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad > 0 && prmFactor == 0)
            {
                atrCapacidad = 500;
                atrFactorCrecimiento = 0;
                atrFlexible = false;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad > 0 && prmFactor > 0)
            {
                atrCapacidad = 500;
                atrFactorCrecimiento = 500;
                atrItems = new Tipo[atrCapacidad];
            }
            else
            {
                atrCapacidad = prmCapacidad;
                atrItems = new Tipo[atrCapacidad];
            }
        }
        #endregion
        #region CRUD
        public bool desencolar(ref Tipo prmItem)
        {
            return extraerEn(0,ref prmItem);
        }
        public bool encolar(Tipo prmItem)
        {
            return insertarEn(atrLongitud,prmItem);
        }
        public bool revisar(ref Tipo prmItem)
        {
            return revisarEn(0,ref prmItem);
        }
        #endregion
        #endregion
    }
}
