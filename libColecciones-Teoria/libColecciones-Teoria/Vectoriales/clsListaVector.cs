using System;
using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Tads;

namespace Servicios.Colecciones.Vectoriales
{
    public class clsListaVector<Tipo> : clsTADVectorial<Tipo>, iLista<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Metodos
        #region Constructores
        public clsListaVector()
        {
            testItems = new Tipo[0];
            if (atrCapacidad == 0)
            {
                atrItems = new Tipo[atrCapacidad];
            }
        }
        public clsListaVector(int prmCapacidad)
        {
            if ((prmCapacidad < 0) || (prmCapacidad == int.MaxValue / 16 + 1) || (prmCapacidad == int.MaxValue))
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
        public clsListaVector(int prmCapacidad, bool prmDinamica)
        {
            if ((prmCapacidad < 0 && prmDinamica == true) || (prmCapacidad < 0 && prmDinamica == false) || (prmCapacidad == int.MaxValue / 16 + 1 && prmDinamica == true))
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if ((prmCapacidad == int.MaxValue / 16 + 1 && prmDinamica == false) || (prmCapacidad == int.MaxValue && prmDinamica == true) || (prmCapacidad == int.MaxValue && prmDinamica == false))
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
        public clsListaVector(int prmCapacidad, int prmFactor)
        {
            if ((prmCapacidad < 0 && prmFactor < 0) || (prmCapacidad < 0 && prmFactor > 0) || (prmCapacidad > 0 && prmFactor < 0) || (prmCapacidad == 0 && prmFactor == 0) || (prmCapacidad < 0 && prmFactor == 0) || (prmCapacidad == int.MaxValue / 16 && prmFactor < 0))
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if ((prmCapacidad == int.MaxValue && prmFactor == int.MaxValue / 16 + 1) || (prmCapacidad == int.MaxValue && prmFactor == 0) || (prmCapacidad == int.MaxValue && prmFactor < 0) || (prmCapacidad == int.MaxValue && prmFactor > 0))
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
            else if ((prmCapacidad == int.MaxValue / 16 && prmFactor > 0) || (prmCapacidad == int.MaxValue / 16 && prmFactor == int.MaxValue / 16 + 1) || (prmCapacidad == int.MaxValue / 16 + 1 && prmFactor < 0) || (prmCapacidad == int.MaxValue / 16 + 1 && prmFactor == 0))
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue / 16 + 1 && prmFactor > 0)
            {
                atrFlexible = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if ((prmCapacidad == int.MaxValue / 16 + 1 && prmFactor == int.MaxValue / 16 + 1) || (prmCapacidad < 0 && prmFactor == int.MaxValue / 16 + 1) || (prmCapacidad == 0 && prmFactor == int.MaxValue / 16 + 1) || (prmCapacidad > 0 && prmFactor == int.MaxValue / 16 + 1) || (prmCapacidad == 0 && prmFactor < 0))
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
        public bool agregar(Tipo prmItem)
        {
            return insertarEn(atrLongitud, prmItem);
        }
        public bool insertar(int prmIndice, Tipo prmItem)
        {
            return insertarEn(prmIndice,prmItem);
        }
        public bool extraer(int prmIndice, ref Tipo prmItem)
        {
            return extraerEn(prmIndice,ref prmItem);
        }
        public bool modificar(int prmIndice, Tipo prmItem)
        {
            return modificarEn(prmIndice,prmItem);
        }
        public bool recuperar(int prmIndice, ref Tipo prmItem)
        {
            return revisarEn(prmIndice,ref prmItem);
        }
        #endregion
        #endregion
    }
}
