using Servicios.Colecciones.Interfaces;
using System;

namespace Servicios.Colecciones.Vectoriales
{
    public class clsPilaVector<Tipo> : iPila<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        private Tipo[] atrItems;
        private int atrCapacidad;
        private int atrLongitud;
        private bool atrDinamica;
        private int atrFactorCrecimiento;
        private bool atrAjustarFC;
        private bool atrFlexibilidad;
        private bool atrReversar;
        private int[] testItems;
        #endregion
        #region Metodos
        #region Accesores
        public Tipo[] darItems() //metodo para accceder al arreglo
        {
            return atrItems;
        }
        public int darCapacidad() //metodo para acceder a la capacidad
        {
            return atrCapacidad;
        }
        public int darLongitud() //metodo para acceder a la longitud
        {
            return atrLongitud;
        }
        public bool esFlexible()// metodo para saber si es flexible
        {
            return atrDinamica;
        }
        public int darFactorCrecimiento() // metodo para acceder a el factorcrecimiento
        {
            return atrFactorCrecimiento;
        }
        #endregion
        #region Constructores
        public clsPilaVector()
        {
            testItems = new int[0];
            if (atrCapacidad == 0)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
        }
        public clsPilaVector(int prmCapacidad)
        {
            if (prmCapacidad < 0)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
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
                atrCapacidad = 0;
                atrItems = new Tipo[atrCapacidad];
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
            }
            else if (prmCapacidad == int.MaxValue)
            {
                atrCapacidad = 0;
                atrItems = new Tipo[atrCapacidad];
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
            }
            else
            {
                atrCapacidad = prmCapacidad;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }

        }
        public clsPilaVector(int prmCapacidad, bool prmDinamica)
        {
            if (prmCapacidad < 0 && prmDinamica == true)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad < 0 && prmDinamica == false)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue / 16 + 1 && prmDinamica == true)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue / 16 + 1 && prmDinamica == false)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue && prmDinamica == true)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue && prmDinamica == false)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
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
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
        }
        public clsPilaVector(int prmCapacidad, int prmFactor)
        {
            if (prmCapacidad < 0 && prmFactor < 0)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad < 0 && prmFactor == 0)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue && prmFactor == 0)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue && prmFactor < 0)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue && prmFactor > 0)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue && prmFactor == int.MaxValue / 16 + 1)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue / 16 && prmFactor < 0)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
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
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue / 16 && prmFactor == int.MaxValue / 16 + 1)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue / 16 + 1 && prmFactor < 0)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue / 16 + 1 && prmFactor == 0)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue / 16 + 1 && prmFactor > 0)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == int.MaxValue / 16 + 1 && prmFactor == int.MaxValue / 16 + 1)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad < 0 && prmFactor == int.MaxValue / 16 + 1)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == 0 && prmFactor == int.MaxValue / 16 + 1)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad > 0 && prmFactor == int.MaxValue / 16 + 1)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == 0 && prmFactor < 0)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == 0 && prmFactor == 0)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad == 0 && prmFactor > 0)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 500;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad > 0 && prmFactor < 0)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
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
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else if (prmCapacidad < 0 && prmFactor > 0)
            {
                atrCapacidad = 0;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
            else
            {
                atrCapacidad = prmCapacidad;
                atrFactorCrecimiento = 1000;
                atrDinamica = true;
                atrItems = new Tipo[atrCapacidad];
            }
        }
        #endregion
        #region CRUDs
        public bool apilar(Tipo prmItem)
        {
            bool espacio = false;
            /*if(atrCapacidad != atrLongitud)
            {
                atrLongitud = 0;
                atrItems[atrLongitud] = prmItem;
                atrLongitud++;
                espacio = true;
            }else if (atrCapacidad == atrLongitud)
            {
                espacio = false;
            }*/
            if (atrCapacidad >= atrLongitud)
            {
                atrCapacidad = atrFactorCrecimiento;
                atrItems = new Tipo[atrCapacidad];
                for (int i = atrLongitud; i < atrItems.Length - 1; i++)
                {
                    atrItems[i + 1] = atrItems[i];
                    atrItems[i] = prmItem;
                }
                //atrItems[0] = prmItem;
                atrLongitud++;
                espacio = true;
            }
            return espacio;
        }
        public bool desapilar(ref Tipo prmItem)
        {
            throw new System.NotImplementedException();
        }
        public bool revisar(ref Tipo prmItem)
        {
            throw new System.NotImplementedException();
        }
        public bool reversar()
        {
            
            if (atrCapacidad > 0)
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
                for(int i = atrLongitud-1; i >= end; i--)
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
        #region Mutadores
        public bool ponerItems(Tipo[] prmItems)
        {
            bool atrTest = true;
            atrItems = prmItems;
            if (prmItems.Length == int.MaxValue / 16)
            {
                atrCapacidad = atrItems.Length;
                atrLongitud = atrItems.Length;
                atrFactorCrecimiento = 0;
                atrDinamica = false;
            }
            else if (prmItems.Length == int.MaxValue / 16 + 1)
            {
                atrCapacidad = 0;
                atrLongitud = 0;
                atrTest = false;
                atrItems = new Tipo[0];
            }
            atrCapacidad = atrItems.Length;
            atrLongitud = atrItems.Length;
            return atrTest;
        }
        public bool ajustarFlexibilidad(bool prmFlexibilidad)
        {
            if (prmFlexibilidad == false && atrCapacidad > 0)
            {
                atrFlexibilidad = true;
                atrDinamica = false;
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
        #endregion
    }
}
