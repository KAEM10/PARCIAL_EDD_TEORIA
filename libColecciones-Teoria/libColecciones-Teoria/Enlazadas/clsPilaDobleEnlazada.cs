﻿using System;
using Servicios.Colecciones.Interfaces;
using Servicios.Colecciones.Nodos;
using Servicios.Colecciones.Tads;

namespace Servicios.Colecciones.Enlazadas
{
    public class clsPilaDobleEnlazada<Tipo> : clsTADDobleEnlazado<Tipo>, iPila<Tipo> where Tipo : IComparable<Tipo>
    {
        #region Atributos
        #region Asociativo
        private clsNodoDobleEnlazado<Tipo> atrPrimero;
        private clsNodoDobleEnlazado<Tipo> atrUltimo;
        #endregion
        private Tipo[] atrItems;
        private int atrLongitud;
        #endregion
        #region Metodos
        #region Constructores
        public clsPilaDobleEnlazada()
        {
            atrLongitud = 0;
            atrItems = null;
            atrPrimero = null;
            atrUltimo = null;
        }
        #endregion
        #region CRUDs
        public bool apilar(Tipo prmItem)
        {
            bool apilo = false;
            clsNodoDobleEnlazado<Tipo> nodoNuevo = new clsNodoDobleEnlazado<Tipo>(prmItem);
            clsNodoDobleEnlazado<Tipo> nodoTemporal = atrPrimero;
            if (atrPrimero == null)
            {
                atrPrimero = nodoNuevo;
                atrUltimo = nodoNuevo;
            }
            else
            {
                nodoNuevo.enlazarSiguiente(nodoTemporal);
                atrPrimero.enlazarAnterior(nodoNuevo);
                atrPrimero = nodoNuevo;
            }
            atrLongitud++;
            apilo = actualizarAtrItems();
            return apilo;
        }
        public bool desapilar(ref Tipo prmItem)
        {
            bool desapilo = false;
            if (atrLongitud > 0)
            {
                prmItem = atrPrimero.darItem();
                atrPrimero = atrPrimero.pasarItems();
                atrLongitud--;
                desapilo = actualizarAtrItems();
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
                prmItem = atrPrimero.darItem();
                reviso = true;
            }
            else
            {
                prmItem = default(Tipo);
            }
            return reviso;
        }
        public bool actualizarAtrItems()
        {
            bool actualizar = false;
            if (atrLongitud > int.MaxValue / 16)
            {
                atrLongitud--;
                return actualizar;
            }
            atrItems = new Tipo[atrLongitud];
            clsNodoDobleEnlazado<Tipo> nodoTemporal = atrPrimero;
            for (int i = 0; i < atrLongitud; i++)
            {
                atrItems[i] = nodoTemporal.darItem();
                if (nodoTemporal.pasarItems() != null)
                {
                    nodoTemporal = nodoTemporal.pasarItems();
                }
            }
            actualizar = true;
            return actualizar;
        }
        #endregion
        #region Mutadores
        public bool ponerItems(Tipo[] prmItems)
        {
            bool atrTest = true;

            atrItems = prmItems;
            if (prmItems.Length == 0)
            {
                atrTest = false;
            }
            else if (prmItems.Length == int.MaxValue / 16)
            {
                atrLongitud = atrItems.Length;
                return atrTest;
            }
            else if (prmItems.Length == int.MaxValue / 16 + 1)
            {
                atrLongitud = 0;
                atrTest = false;
                atrItems = new Tipo[0];
                atrItems = default(Tipo[]);
            }
            else
            {
                for (int i = atrItems.Length - 1; i >= 0; i--)
                {
                    if (atrItems[i] != null)
                    {
                        clsNodoDobleEnlazado<Tipo> nodoNuevo = new clsNodoDobleEnlazado<Tipo>(atrItems[i]);

                        if (atrPrimero == null)
                        {
                            atrPrimero = nodoNuevo;
                            atrUltimo = nodoNuevo;
                        }
                        else
                        {
                            nodoNuevo.enlazarSiguiente(atrPrimero);
                            atrPrimero.enlazarAnterior(nodoNuevo);
                            atrPrimero = nodoNuevo;
                        }
                    }
                }
                atrLongitud = atrItems.Length;
            }
            return atrTest;
        }
        #endregion
        #endregion
    }
}
