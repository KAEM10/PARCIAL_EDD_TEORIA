using System;
using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Tads;

namespace Servicios.Colecciones.Vectoriales
{
    public class clsListaVector<Tipo> : clsTADVectorial<Tipo>, iLista<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        private Tipo[] atrItems;
        private int atrCapacidad = 0, atrLongitud, atrFactorCrecimiento = 1000;
        private bool atrDinamica = true;
        private int[] testItems;
        #endregion
        #region Metodos
        #region Constructores
        public clsListaVector()
        {
            testItems = new int[0];
            if (atrCapacidad == 0)
            {
                atrItems = new Tipo[atrCapacidad];
            }
        }
        public clsListaVector(int prmCapacidad)
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
                atrDinamica = false;
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
        public clsListaVector(int prmCapacidad, bool prmDinamica)
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
                atrDinamica = false;
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
                atrDinamica = false;
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
                atrDinamica = true;
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
                atrDinamica = false;
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
        #region CRUD
        public bool agregar(Tipo prmItem)
        {
            bool agrego = false;
            if (atrCapacidad == 0)
            {
                atrCapacidad = atrFactorCrecimiento;
                atrItems = new Tipo[atrCapacidad];
            }
            if ((atrCapacidad != int.MaxValue / 16) && (atrCapacidad == atrLongitud) && atrDinamica)
            {
                Tipo[] atrItemsAux = new Tipo[atrFactorCrecimiento + atrCapacidad];
                Array.Copy(atrItems, atrItemsAux, atrItems.Length);
                atrItems = atrItemsAux;

                atrCapacidad = atrFactorCrecimiento + atrCapacidad;
            }
            if (atrLongitud < atrCapacidad)
            {
                atrItems[atrLongitud] = prmItem;
                atrLongitud++;
                agrego = true;
            }
            return agrego;
        }
        public bool insertar(int prmIndice, Tipo prmItem)
        {
            bool inserto = false;
            if ((prmIndice >= 0) && (prmIndice <= atrLongitud))
            {
                if ((atrCapacidad != int.MaxValue / 16) && (atrCapacidad == atrLongitud) && atrDinamica)
                {
                    Tipo[] atrItemsAux = new Tipo[atrFactorCrecimiento + atrCapacidad];
                    Array.Copy(atrItems, atrItemsAux, atrItems.Length);
                    atrItems = atrItemsAux;

                    atrCapacidad = atrFactorCrecimiento + atrCapacidad;

                }
                if ((prmIndice < atrCapacidad) && (atrLongitud < atrCapacidad))
                {
                    for (int i = atrLongitud + 1; i > prmIndice; i--)
                    {
                        atrItems[i] = atrItems[i - 1];
                    }
                    atrItems[prmIndice] = prmItem;
                    atrLongitud++;
                    inserto = true;

                }

            }

            return inserto;
        }
        public bool extraer(int prmIndice, ref Tipo prmItem)
        {
            bool extraer = false;

            if ((prmIndice >= 0) && (prmIndice < atrLongitud))
            {
                if ((atrLongitud > 0) && (atrItems[prmIndice] != null))
                {
                    prmItem = atrItems[prmIndice];
                    for (int i = prmIndice; i < (atrLongitud - 1); i++)
                    {
                        atrItems[i] = atrItems[i + 1];
                    }
                    extraer = true;
                    atrLongitud--;
                }

            }

            return extraer;
        }
        public bool modificar(int prmIndice, Tipo prmItem)
        {
            bool modifico = false;
            if ((prmIndice >= 0) && (prmIndice < atrLongitud))
            {
                atrItems[prmIndice] = prmItem;
                modifico = true;
            }

            return modifico;
        }
        public bool recuperar(int prmIndice, ref Tipo prmItem)
        {
            bool recupero = false;
            if ((prmIndice >= 0) && (prmIndice < atrLongitud))
            {
                prmItem = atrItems[prmIndice];
                recupero = true;
            }
            else
            {
                prmItem = default(Tipo);
            }


            return recupero;
        }
        #endregion
        #endregion
    }
}
