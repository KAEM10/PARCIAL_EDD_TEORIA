using System;
using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Tads;

namespace Servicios.Colecciones.Vectoriales
{
    public class clsListaVector<Tipo> : clsTADVectorial<Tipo>, iLista<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Metodos
        #region Accesores
        public override int darLongitud()
        {
            return atrLongitud;
        }
        public override bool estaVacia()
        {
            throw new NotImplementedException();
        }
        public override Tipo[] darItems()
        {
            return atrItems;
        }
        public override int darCapacidad()
        {
            return atrCapacidad;
        }
        public override int darFactorCrecimiento()
        {
            return atrFactorCrecimiento;
        }
        public override bool esFlexible()
        {
            return atrFlexible;
        }
        #endregion
        #region Mutadores
        public override bool ponerItems(Tipo[] prmItems)
        {
            bool atrTest = true;
            atrItems = prmItems;
            if (prmItems.Length == int.MaxValue / 16)
            {
                atrCapacidad = atrItems.Length;
                atrLongitud = atrItems.Length;
                atrFactorCrecimiento = 0;
                atrFlexible = false;
            }
            else if (prmItems.Length == int.MaxValue / 16 + 1)
            {
                atrLongitud = 0;
                atrTest = false;
                atrItems = new Tipo[0];
            }
            atrCapacidad = atrItems.Length;
            atrLongitud = atrItems.Length;
            return atrTest;
        }
        public override bool ajustarFlexibilidad(bool prmFlexibilidad)
        {
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
        public override bool ponerCapacidad(int prmValor)
        {
            throw new NotImplementedException();
        }
        public override bool ponerFactorCrecimiento(int prmFactorCre)
        {
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
        public bool ajustarFactorCrecimiento(int prmFactorCre)
        {
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
        #region CRUD
        public bool agregar(Tipo prmItem)
        {
            bool agrego = false;
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
                if ((atrCapacidad != int.MaxValue / 16) && (atrCapacidad == atrLongitud) && atrFlexible)
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
        public override bool limpiar()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region QUERY
        public override int encontrar(Tipo prmItem)
        {
            int atrIndice = -1;
            if (atrLongitud > 0)
            {
                for (int i = 0; i < atrLongitud; i++)
                {
                    if (atrItems[i].Equals(prmItem))
                    {
                        atrIndice = i;
                        break;
                    }
                }
            }
            return atrIndice;
        }
        public override bool contiene(Tipo prmItem)
        {
            bool contiene = false;
            if (atrLongitud > 0)
            {
                for (int i = 0; i < atrLongitud; i++)
                {
                    if (atrItems[i].Equals(prmItem))
                    {
                        contiene = true;
                        break;
                    }
                }
            }
            return contiene;
        }
        #endregion
        #region Sorting
        public override bool reversar()
        {
            if (atrLongitud > 0)
            {
                Tipo aux;
                int j = 0;
                int end;
                if (atrLongitud % 2 == 0)
                {
                    end = (atrLongitud) / 2;
                }
                else
                {
                    end = (atrLongitud - 1) / 2;
                }
                for (int i = atrLongitud - 1; i >= end; i--)
                {
                    aux = atrItems[j];
                    atrItems[j] = atrItems[i];
                    atrItems[i] = aux;
                    j++;
                }
                atrReversar = true;
                return atrReversar;
            }
            else
            {
                return atrReversar;
            }
        }
        #endregion
        #endregion
    }
}
