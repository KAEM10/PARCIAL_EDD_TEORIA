﻿using System;
using Servicios.Colecciones.Interfaces;

namespace Servicios.Colecciones.Vectoriales
{
    public class clsListaVector<Tipo> : iLista<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Metodos
        #region CRUD
        public bool agregar(Tipo prmItem)
        {
            throw new NotImplementedException();
        }

        public bool insertar(int prmIndice, Tipo prmItem)
        {
            throw new NotImplementedException();
        }

        public bool remover(int prmIndice, ref Tipo prmItem)
        {
            throw new NotImplementedException();
        }

        public bool modificar(int prmindice, Tipo prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region QUERY

        public bool encontrar(Tipo prmItem, ref int prmIndice)
        {
            throw new NotImplementedException();
        }

        #endregion
        #endregion
    }
}
