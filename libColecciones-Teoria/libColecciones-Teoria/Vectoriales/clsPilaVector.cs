using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Tads;
using System;

namespace Servicios.Colecciones.Vectoriales
{
    public class clsPilaVector<Tipo> : clsTADVectorial<Tipo>, iPila<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        private Tipo[] atrItems;
        private int atrCapacidad = 0, atrLongitud, atrFactorCrecimiento = 1000;
        private bool atrFlexible = true, atrAjustarFC;
        #endregion
        #region Metodos
        #region Accesores
        public bool ponerCapacidad(int prmValor)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Constructores
        public clsPilaVector()
        {
            //testItems = new int[0];
            if (atrCapacidad == 0)
            {
                atrItems = new Tipo[atrCapacidad];
            }
        }
        public clsPilaVector(int prmCapacidad)
        {
            if (prmCapacidad < 0)
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
            else if (prmCapacidad == int.MaxValue / 16 + 1)
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue)
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else
            {
                atrCapacidad = prmCapacidad;
                atrItems = new Tipo[atrCapacidad];
            }

        }
        public clsPilaVector(int prmCapacidad, bool prmDinamica)
        {
            if (prmCapacidad < 0 && prmDinamica == true)
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad < 0 && prmDinamica == false)
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue / 16 + 1 && prmDinamica == true)
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue / 16 + 1 && prmDinamica == false)
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue && prmDinamica == true)
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue && prmDinamica == false)
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
        public clsPilaVector(int prmCapacidad, int prmFactor)
        {
            if (prmCapacidad < 0 && prmFactor < 0)
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad < 0 && prmFactor == 0)
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue && prmFactor == 0)
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue && prmFactor < 0)
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue && prmFactor > 0)
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue && prmFactor == int.MaxValue / 16 + 1)
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue / 16 && prmFactor < 0)
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
            else if (prmCapacidad == int.MaxValue / 16 && prmFactor > 0)
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue / 16 && prmFactor == int.MaxValue / 16 + 1)
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue / 16 + 1 && prmFactor < 0)
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue / 16 + 1 && prmFactor == 0)
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue / 16 + 1 && prmFactor > 0)
            {
                atrFlexible = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue / 16 + 1 && prmFactor == int.MaxValue / 16 + 1)
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad < 0 && prmFactor == int.MaxValue / 16 + 1)
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == 0 && prmFactor == int.MaxValue / 16 + 1)
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad > 0 && prmFactor == int.MaxValue / 16 + 1)
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == 0 && prmFactor < 0)
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == 0 && prmFactor == 0)
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == 0 && prmFactor > 0)
            {
                atrFactorCrecimiento = 500;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad > 0 && prmFactor < 0)
            {
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
            else if (prmCapacidad < 0 && prmFactor > 0)
            {
                atrItems = new Tipo[atrCapacidad];
            }
            else
            {
                atrCapacidad = prmCapacidad;
                atrItems = new Tipo[atrCapacidad];
            }
        }
        #endregion
        #region CRUDs
        public bool apilar(Tipo prmItem)
        {
            bool apilo = false;
            if (atrCapacidad == 0)
            {
                atrCapacidad = atrFactorCrecimiento;
                atrItems = new Tipo[atrCapacidad];
            }
            if ((atrCapacidad != int.MaxValue / 16) && (atrCapacidad == atrLongitud) && atrFlexible)
            {
                Tipo[] atrItemsAux = new Tipo[atrFactorCrecimiento + atrCapacidad];
                Array.Copy(atrItems, atrItemsAux, atrItems.Length);
                atrItems = atrItemsAux;

                atrCapacidad = atrFactorCrecimiento + atrCapacidad;
            }
            if (atrLongitud < atrCapacidad)
            {
                for (int i = atrLongitud + 1; i > 0; i--)
                {
                    atrItems[i] = atrItems[i - 1];
                }
                atrItems[0] = prmItem;
                atrLongitud++;
                apilo = true;
            }
            return apilo;
        }
        public bool desapilar(ref Tipo prmItem)
        {
            bool desapilo = false;
            if (atrLongitud > 0)
            {
                prmItem = atrItems[0];
                for (int i = 0; i < (atrLongitud - 1); i++)
                {
                    atrItems[i] = atrItems[i + 1];
                }
                desapilo = true;
                atrLongitud--;
            }
            else
            {
                prmItem = default(Tipo);
            }

            return desapilo;
        }
        public bool revisar(ref Tipo prmItem)
        {
            bool reviso = false;
            if (atrLongitud > 0)
            {
                prmItem = atrItems[0];
                reviso = true;
            }
            else
            {
                prmItem = default(Tipo);
            }
            return reviso;
        }
        #endregion
        #region Ordenamiento
        public bool OrdenarBurbujaSimple(bool prmOrden)
        {
            return false;
        }
        public bool OrdenarBurbujaMejorado(bool prmOrden)
        {
            return false;
        }
        public bool OrdenarBurbujaBiDireccional(bool prmOrden)
        {
            return false;
        }
        public bool OrdenarInsercion(bool prmOrden)
        {
            return false;
        }
        public bool OrdenarQuickSort(bool prmOrden)
        {
            return false;
        }
        public bool OrdenarSeleccion(bool prmOrden)
        {
            return false;
        }
        #endregion
        #region QUERY
        public int encontrar(Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        public bool contiene(Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}
