using System;
using Servicios.Colecciones.Interfaces;

namespace Servicios.Colecciones.Tads
{
    public class clsTADVectorial<Tipo>: clsTAD<Tipo>,iTADVectorial<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        protected int atrCapacidad = 0, atrFactorCrecimiento = 1000;
        protected bool atrFlexible = true, atrFlexibilidad, atrAjustarFC, atrReversar;
        protected Tipo[] testItems;
        
        #endregion
        #region Metodos
        #region Accesores
        
        public virtual int darCapacidad()
        {
            return atrCapacidad;
        }
        public virtual int darFactorCrecimiento()
        {
            return atrFactorCrecimiento;
        }
        public virtual bool esFlexible()
        {
            return atrFlexible;
        }
        
        #endregion
        #region Mutadores
        public virtual bool ajustarFlexibilidad(bool prmFlexibilidad)
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
        public virtual bool ponerCapacidad(int prmValor)
        {
            bool modificado = false;
            if (atrLongitud < atrCapacidad)
            {
                Tipo[] auxItems = new Tipo[prmValor];
                Array.Copy(atrItems, auxItems, atrItems.Length);
                atrItems = auxItems;
                atrCapacidad = prmValor;
                modificado = true;
            }
            return modificado;
        }
        public virtual bool ponerFactorCrecimiento(int prmFactorCre)
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
        #region CRUD
        public override bool insertarEn(int prmIndice, Tipo prmItem)
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
                    for (int i = atrLongitud; i > prmIndice; i--)
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
        public override bool extraerEn(int prmIndice, ref Tipo prmItem)
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
            else
            {
                prmItem = default(Tipo);
            }
            return extraer;
        }
        public override bool modificarEn(int prmIndice, Tipo prmItem)
        {
            bool modifico = false;
            if ((prmIndice >= 0) && (prmIndice < atrLongitud))
            {
                atrItems[prmIndice] = prmItem;
                modifico = true;
            }
            return modifico;
        }
        public override bool revisarEn(int prmIndice, ref Tipo prmItem)
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
        #region Ordenamiento
        public bool OrdenarBurbujaSimple(bool prmOrden)
        {
            bool ordenado = false;
            Tipo aux;
            if(atrLongitud > 0)
            {
                if (prmOrden) // true = mayor a menor
                {
                    while (!ordenado)
                    {
                        ordenado = true;
                        for (int i = 0; i < atrLongitud - 1; i++)
                        {
                            if (Int32.Parse(atrItems[i].ToString()) < Int32.Parse(atrItems[i + 1].ToString()))
                            {
                                aux = atrItems[i + 1];
                                atrItems[i + 1] = atrItems[i];
                                atrItems[i] = aux;
                                ordenado = false;
                            }
                        }
                    }
                }
                else // false = menor a mayor
                {
                    while (!ordenado)
                    {
                        ordenado = true;
                        for (int i = 0; i < atrLongitud - 1; i++)
                        {
                            if (Int32.Parse(atrItems[i].ToString()) > Int32.Parse(atrItems[i + 1].ToString()))
                            {
                                aux = atrItems[i + 1];
                                atrItems[i + 1] = atrItems[i];
                                atrItems[i] = aux;
                                ordenado = false;
                            }
                        }
                    }
                }
                
            }
            return ordenado;
        }
        public bool OrdenarBurbujaMejorado(bool prmOrden)
        {
            bool ordenado = false;
            Tipo aux;
            if(atrLongitud > 0)
            {
                if (prmOrden)
                {  // true Descendente
                    for (int i = 0; i < atrLongitud; i++)
                    {
                        for (int j = i + 1; j < atrLongitud; j++)
                        {
                            if (Int32.Parse(atrItems[i].ToString()) < Int32.Parse(atrItems[j].ToString()))
                            {
                                aux = atrItems[j];
                                atrItems[j] = atrItems[i];
                                atrItems[i] = aux;
                            }
                        }
                    }
                }
                else //false Ascendente
                {
                    for (int i = 0; i < atrLongitud; i++)
                    {
                        for (int j = i + 1; j < atrLongitud; j++)
                        {
                            if (Int32.Parse(atrItems[i].ToString()) > Int32.Parse(atrItems[j].ToString()))
                            {
                                aux = atrItems[j];
                                atrItems[j] = atrItems[i];
                                atrItems[i] = aux;
                            }
                        }
                    }
                }
                ordenado = true;
            }
            

            return ordenado;
        }
        public bool OrdenarBurbujaBiDireccional(bool prmOrden)
        {
            bool ordenado = false;
            int izq = 0;
            int der = atrLongitud - 1;
            Tipo aux;
            int ultimo = atrLongitud - 1;
            if (atrLongitud > 0)
            {
                if (prmOrden)
                {
                    do
                    {
                        for (int i = izq; i < der; i++)
                        {
                            if (Int32.Parse(atrItems[i].ToString()) < Int32.Parse(atrItems[i + 1].ToString()))
                            {
                                aux = atrItems[i];
                                atrItems[i] = atrItems[i + 1];
                                atrItems[i + 1] = aux;
                                ultimo = i;
                            }
                        }

                        der = ultimo;

                        for (int j = der; j > izq; j--)
                        {
                            if (Int32.Parse(atrItems[j - 1].ToString()) < Int32.Parse(atrItems[j].ToString()))
                            {
                                aux = atrItems[j];
                                atrItems[j] = atrItems[j - 1];
                                atrItems[j - 1] = aux;
                                ultimo = j;
                            }
                        }
                        izq = ultimo;
                    } while (izq < der);
                }
                else
                {
                    do
                    {
                        for (int i = izq; i < der; i++)
                        {
                            if (Int32.Parse(atrItems[i].ToString()) > Int32.Parse(atrItems[i + 1].ToString()))
                            {
                                aux = atrItems[i];
                                atrItems[i] = atrItems[i + 1];
                                atrItems[i + 1] = aux;
                                ultimo = i;
                            }
                        }

                        der = ultimo;

                        for (int j = der; j > izq; j--)
                        {
                            if (Int32.Parse(atrItems[j - 1].ToString()) > Int32.Parse(atrItems[j].ToString()))
                            {
                                aux = atrItems[j];
                                atrItems[j] = atrItems[j - 1];
                                atrItems[j - 1] = aux;
                                ultimo = j;
                            }
                        }
                        izq = ultimo;
                    } while (izq < der);
                }
                ordenado = true;
            }
            return ordenado;
        }
        public bool OrdenarInsercion(bool prmOrden)
        {
            throw new NotImplementedException();
        }
        public bool OrdenarQuickSort(bool prmOrden)
        {
            throw new NotImplementedException();
        }
        public bool OrdenarSeleccion(bool prmOrden)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}
