using System;

namespace Servicios.Colecciones.Interfaces
{
    public interface iPila<Tipo> where Tipo:IComparable<Tipo>
    {
        #region CRUD
        bool apilar(Tipo prmItem);
        bool desapilar(ref Tipo prmItem);
        bool revisar(ref Tipo prmItem);
        bool reversar();
        #endregion
    }
}
