using System;
using Servicios.Colecciones.Interfaces;
namespace Servicios.Colecciones.Nodos
{
    public class clsNodo<Tipo> :iNodo<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        #region Propios
        protected Tipo atrItem;
        #endregion
        #endregion
        public Tipo darItem()
        {
            return atrItem;
        }
        public bool ponerItem(Tipo Item)
        {
            atrItem = Item;
            return false;
        }
    }
}
