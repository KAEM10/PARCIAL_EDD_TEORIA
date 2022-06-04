using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Colecciones.Vectoriales;

namespace Colecciones.Servicios.Pruebas
    {
    [TestClass]
    public class uTestColaVector
        {
        #region Atributos de Prueba
        private clsColaVector<int> testCola;
        private int[] testItems;
        private int testItem;
        #endregion
        #region Casos de Prueba
        #region Constructores
        #region Constructor NO Parametrizado Por Defecto
        [TestMethod]
        public void uTestConstructorNoParametrizado()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>();
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        #endregion
        #region Constructor con Capacidad
        [TestMethod]
        public void uTestConstructor1CapacidadNegativa()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(-100);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor1CapacidadCero()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(0);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor1CapacidadNormal()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(500);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(500, testCola.darItems().Length);
            Assert.AreEqual(500, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor1CapacidadEnBorde()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(int.MaxValue / 16);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(int.MaxValue/16, testCola.darItems().Length);
            Assert.AreEqual(int.MaxValue/16, testCola.darCapacidad());
            Assert.AreEqual(false, testCola.esDinamica());
            Assert.AreEqual(0, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor1CapacidadFueraDeBorde()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(int.MaxValue / 16 + 1);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor1CapacidadEnMaxValue()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(int.MaxValue);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        #endregion
        #region Constructor con Capacidad y Tipo de Flexibilidad
        [TestMethod]
        public void uTestConstructor2CapacidadNegativaFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(-100, true);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadNegativaNOFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(-100, false);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadCeroFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(0, true);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadCeroNOFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(0, false);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadNormalFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(500, true);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(500, testCola.darItems().Length);
            Assert.AreEqual(500, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadNormalNOFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(500, false);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(500, testCola.darItems().Length);
            Assert.AreEqual(500, testCola.darCapacidad());
            Assert.AreEqual(false, testCola.esDinamica());
            Assert.AreEqual(0, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadMasAllaBordeFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(int.MaxValue / 16 + 1, true);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadMasAllaBordeNOFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(int.MaxValue / 16 + 1, false);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadEnMaxValueFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(int.MaxValue, true);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadEnMaxValueNOFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(int.MaxValue, false);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        #endregion
        #region Constructor con Capacidad y Factor de Crecimiento
        [TestMethod]
        public void uTestConstructor3CapacidadNegativaFactorCrecimientoNegativo()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(-100,-10);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadNegativaFactorCrecimientoCero()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(-100, 0);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadNegativaFactorCrecimientoNormal()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(-100, 10);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadNegativaFactorCrecimientoMasAllaBorde()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(-100, int.MaxValue/16+1);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }

        [TestMethod]
        public void uTestConstructor3CapacidadCeroFactorCrecimientoNegativo()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(0,-1);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadCeroFactorCrecimientoCero()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(0, 0);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadCeroFactorCrecimientoNormal()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(0, 500);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(500, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadCeroFactorCrecimientoMasAllaBorde()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(0, int.MaxValue / 16 + 1);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }

        [TestMethod]
        public void uTestConstructor3CapacidadNormalFactorCrecimientoNegativo()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(500,-1);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadNormalFactorCrecimientoCero()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(500, 0);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(500, testCola.darItems().Length);
            Assert.AreEqual(500, testCola.darCapacidad());
            Assert.AreEqual(false, testCola.esDinamica());
            Assert.AreEqual(0, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadNormalFactorCrecimientoNormal()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(500, 500);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(500, testCola.darItems().Length);
            Assert.AreEqual(500, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(500, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadNormalFactorCrecimientoMasAllaBorde()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(500, int.MaxValue/16+1);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(00, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }

        [TestMethod]
        public void uTestConstructor3CapacidadEnBordeFactoCrecimientoNegativo()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(int.MaxValue / 16,-1);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadEnBordeFactoCrecimientoCero()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(int.MaxValue / 16, 0);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(int.MaxValue / 16, testCola.darItems().Length);
            Assert.AreEqual(int.MaxValue / 16, testCola.darCapacidad());
            Assert.AreEqual(false, testCola.esDinamica());
            Assert.AreEqual(0, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadEnBordeFactoCrecimientoNormal()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(int.MaxValue / 16, 500);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadEnBordeFactoCrecimientoMasAllaBorde()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(int.MaxValue / 16, int.MaxValue/16+1);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }

        [TestMethod]
        public void uTestConstructor3CapacidadFueraDeBordeFactorCrecimientoNegativo()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(int.MaxValue / 16 + 1, -1);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadFueraDeBordeFactorCrecimientoCero()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(int.MaxValue / 16 + 1, 0);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadFueraDeBordeFactorCrecimientoNormal()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(int.MaxValue / 16 + 1, 500);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadFueraDeBordeFactorCrecimientoMasAllaBorde()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(int.MaxValue / 16 + 1, int.MaxValue/16+1);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }

        [TestMethod]
        public void uTestConstructor3CapacidadEnMaxValueFactorCrecimientoNegativo()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(int.MaxValue, -1);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadEnMaxValueFactorCrecimientoCero()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(int.MaxValue, 0);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadEnMaxValueBordeFactorCrecimientoNormal()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(int.MaxValue, 500);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadEnMaxValueFactorCrecimientoMasAllaBorde()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testCola = new clsColaVector<int>(int.MaxValue, int.MaxValue/16+1);
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        #endregion
        #endregion
        #region Mutadores
        [TestMethod]
        public void uTestPonerItemsConLongitudCero()
            {
            #region Configurar
            testCola = new clsColaVector<int>();
            testItems = new int[0];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testCola.ponerItems(testItems));
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestPonerItemsConLongitudNormal()
            {
            #region Configurar
            testCola = new clsColaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testCola.ponerItems(testItems));
            Assert.AreEqual(3, testCola.darCapacidad());
            Assert.AreEqual(3, testCola.darLongitud());
            Assert.AreEqual(1, testCola.darItems()[0]);
            Assert.AreEqual(2, testCola.darItems()[1]);
            Assert.AreEqual(3, testCola.darItems()[2]);
            Assert.AreEqual(3, testCola.darItems().Length);
            #endregion
            }
        [TestMethod]
        public void uTestPonerItemsConLongitudEnBorde()
            {
            #region Configurar
            testCola = new clsColaVector<int>();
            testItems = new int[int.MaxValue/16];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testCola.ponerItems(testItems));
            Assert.AreEqual(int.MaxValue/16, testCola.darCapacidad());
            Assert.AreEqual(int.MaxValue / 16, testCola.darLongitud());
            Assert.AreEqual(int.MaxValue / 16, testCola.darItems().Length);
            Assert.AreEqual(false, testCola.esDinamica());
            Assert.AreEqual(0, testCola.darFactorCrecimiento());
            for (int varIterador = 0; varIterador < int.MaxValue / 16; varIterador++)
                Assert.AreEqual(0, testCola.darItems()[varIterador]);
            #endregion
            }
        [TestMethod]
        public void uTestPonerItemsConLongitudMasAllaDelBorde()
            {
            #region Configurar
            testCola = new clsColaVector<int>();
            testItems = new int[int.MaxValue / 16 + 1];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testCola.ponerItems(testItems));
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darItems().Length);
            #endregion
            }

        [TestMethod]
        public void uTestAjustarFlexibilidadCapacidadEnBorde()
            {
            #region Configurar
            testCola = new clsColaVector<int>(int.MaxValue/16);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testCola.ajustarFlexibilidad(true));
            Assert.AreEqual(false, testCola.esDinamica());
            Assert.AreEqual(0, testCola.darFactorCrecimiento());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(int.MaxValue / 16, testCola.darCapacidad());
            Assert.AreEqual(int.MaxValue / 16, testCola.darItems().Length);
            #endregion
            }
        [TestMethod]
        public void uTestAjustaFlexibilidadCapacidadEnCero()
            {
            #region Configurar
            testCola = new clsColaVector<int>(0);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testCola.ajustarFlexibilidad(false));
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(0, testCola.darItems().Length);
            #endregion
            }
        [TestMethod]
        public void uTestAjustarFlexibilidadCapacidadNormal()
            {
            #region Configurar
            testCola = new clsColaVector<int>(500);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testCola.ajustarFlexibilidad(false));
            Assert.AreEqual(false, testCola.esDinamica());
            Assert.AreEqual(0, testCola.darFactorCrecimiento());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(500, testCola.darCapacidad());
            Assert.AreEqual(500, testCola.darItems().Length);
            #endregion
            }

        [TestMethod]
        public void uTestAjustarFactorCrecimientoNormalEnCapacidadNormal()
            {
            #region Configurar
            testCola = new clsColaVector<int>(500);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testCola.ajustarFactorCrecimiento(3000));
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(3000, testCola.darFactorCrecimiento());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(500, testCola.darCapacidad());
            Assert.AreEqual(500, testCola.darItems().Length);
            #endregion
            }
        [TestMethod]
        public void uTestAjustarFactorCrecimientoEnBordeEnCapacidadNormal()
            {
            #region Configurar
            testCola = new clsColaVector<int>(500);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testCola.ajustarFactorCrecimiento((int.MaxValue/16)-testCola.darItems().Length));
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(int.MaxValue/16-testCola.darItems().Length, testCola.darFactorCrecimiento());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(500, testCola.darCapacidad());
            Assert.AreEqual(500, testCola.darItems().Length);
            #endregion
            }
        [TestMethod]
        public void uTestAjustarFactorCrecimientoEnBordeConCapacidadEnBorde()
            {
            #region Configurar
            testCola = new clsColaVector<int>(int.MaxValue/16);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testCola.ajustarFactorCrecimiento(int.MaxValue / 16));
            Assert.AreEqual(false, testCola.esDinamica());
            Assert.AreEqual(0, testCola.darFactorCrecimiento());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(int.MaxValue/16, testCola.darCapacidad());
            Assert.AreEqual(int.MaxValue/16, testCola.darItems().Length);
            #endregion
            }
        #endregion
        #region Accesores
        [TestMethod]
        public void uTestDarItems()
            {
            #region Configurar
            testCola = new clsColaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testCola.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreNotEqual(null, testCola.darItems());
            Assert.AreEqual(3, testCola.darItems().Length);
            Assert.AreEqual(1, testCola.darItems()[0]);
            Assert.AreEqual(2, testCola.darItems()[1]);
            Assert.AreEqual(3, testCola.darItems()[2]);
            #endregion
            }
        [TestMethod]
        public void uTestDarLongitud()
            {
            #region Configurar
            testCola = new clsColaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testCola.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(3, testCola.darLongitud());
            #endregion
            }
        [TestMethod]
        public void uTestDarCapacidad()
            {
            #region Configurar
            testCola = new clsColaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testCola.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(3, testCola.darCapacidad());
            #endregion
            }
        [TestMethod]
        public void uTestDarFactorCrecimiento()
            {
            #region Configurar
            testCola = new clsColaVector<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        #endregion
        #region Consultores
        [TestMethod]
        public void uTestEsDinamica()
            {
            #region Configurar
            testCola = new clsColaVector<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testCola.esDinamica());
            #endregion
            }
        #endregion
        #region CRUDs
        #region Encolar
        [TestMethod]
        public void uTestEncolarItemEnTADVacio()
            {
            #region Configurar
            testCola = new clsColaVector<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testCola.encolar(123));
            Assert.AreEqual(123, testCola.darItems()[0]);
            Assert.AreEqual(1, testCola.darLongitud());
            Assert.AreEqual(1000, testCola.darCapacidad());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            Assert.AreEqual(true, testCola.esDinamica());
            #endregion
            }
        [TestMethod]
        public void uTestEncolarItemEnTADConItems()
            {
            #region Configurar
            testCola = new clsColaVector<int>();
            testCola.encolar(123);
            testCola.encolar(456);
            testCola.encolar(789);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testCola.encolar(777));
            Assert.AreEqual(1000, testCola.darCapacidad());
            Assert.AreEqual(4, testCola.darLongitud());
            Assert.AreEqual(777, testCola.darItems()[3]);
            Assert.AreEqual(789, testCola.darItems()[2]);
            Assert.AreEqual(456, testCola.darItems()[1]);
            Assert.AreEqual(123, testCola.darItems()[0]);
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            Assert.AreEqual(true, testCola.esDinamica());
            #endregion
            }
        [TestMethod]
        public void uTestEncolarItemEnTADLleno()
            {
            #region Configurar
            testCola = new clsColaVector<int>();
            testItems = new int[3];
            testItems[0] = 123;
            testItems[1] = 456;
            testItems[2] = 789;
            testCola.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testCola.encolar(777));
            Assert.AreEqual(1003, testCola.darCapacidad());
            Assert.AreEqual(4, testCola.darLongitud());
            Assert.AreEqual(123, testCola.darItems()[0]);
            Assert.AreEqual(456, testCola.darItems()[1]);
            Assert.AreEqual(789, testCola.darItems()[2]);
            Assert.AreEqual(777, testCola.darItems()[3]);
            for (int i = 4; i <= testCola.darItems().Length-1; i++)
                Assert.AreEqual(0, testCola.darItems()[i]);
            #endregion
            }
        [TestMethod]
        public void uTestEncolarItemEnTADLlenoEnBorde()
            {
            #region Configurar
            testCola = new clsColaVector<int>();
            testItems = new int[int.MaxValue / 16];
            testCola.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testCola.encolar(777));
            Assert.AreEqual(int.MaxValue/16, testCola.darCapacidad());
            Assert.AreEqual(int.MaxValue/16, testCola.darLongitud());
            Assert.AreEqual(false, testCola.esDinamica());
            Assert.AreEqual(0, testCola.darFactorCrecimiento());
            Assert.AreEqual(int.MaxValue / 16, testCola.darItems().Length);
            CollectionAssert.AreEqual(testItems, testCola.darItems());
            #endregion
            }
        #endregion
        #region Desencolar
        [TestMethod]
        public void uTestDesencolarEnTADVacio()
            {
            #region Configurar
            testCola = new clsColaVector<int>();
            testItem = -1;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testCola.desencolar(ref testItem));
            Assert.AreEqual(-1, testItem);
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(0, testCola.darItems().Length);
            #endregion
            }
        [TestMethod]
        public void uTestDesencolarEnTADConItems()
            {
            #region Configurar
            testCola = new clsColaVector<int>();
            testCola.encolar(123);
            testCola.encolar(456);
            testCola.encolar(789);
            testItem = 0;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testCola.desencolar(ref testItem));
            Assert.AreEqual(123, testItem);
            Assert.AreEqual(2, testCola.darLongitud());
            Assert.AreEqual(1000, testCola.darCapacidad());
            Assert.AreEqual(1000, testCola.darItems().Length);
            Assert.AreEqual(456, testCola.darItems()[0]);
            Assert.AreEqual(789, testCola.darItems()[1]);
            #endregion
            }
        [TestMethod]
        public void uTestDesencolarEnTADLleno()
            {
            #region Configurar
            testCola = new clsColaVector<int>();
            testItems = new int[3];
            testItems[0] = 123;
            testItems[1] = 456; 
            testItems[2] = 789;
            testCola.ponerItems(testItems);
            testItem = 0;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testCola.desencolar(ref testItem));
            Assert.AreEqual(123, testItem);
            Assert.AreEqual(2, testCola.darLongitud());
            Assert.AreEqual(3, testCola.darCapacidad());
            Assert.AreEqual(456, testCola.darItems()[0]);
            Assert.AreEqual(789, testCola.darItems()[1]);
            Assert.AreEqual(789, testCola.darItems()[2]);
            #endregion
            }
        #endregion
        #region Revisar
        [TestMethod]
        public void uTestRevisarEnTADVacio()
            {
            #region Configurar
            testCola = new clsColaVector<int>();
            testItems = new int[0];
            testItem = -1;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testCola.revisar(ref testItem));
            Assert.AreEqual(-1, testItem);
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(0, testCola.darCapacidad());
            Assert.AreEqual(0, testCola.darItems().Length);
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testCola.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRevisarEnTADConItems()
            {
            #region Configurar
            testCola = new clsColaVector<int>();
            testCola.encolar(123);
            testCola.encolar(456);
            testCola.encolar(789);
            testItem = -1;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testCola.revisar(ref testItem));
            Assert.AreEqual(123, testItem);
            Assert.AreEqual(3, testCola.darLongitud());
            Assert.AreEqual(1000, testCola.darCapacidad());
            Assert.AreEqual(1000, testCola.darItems().Length);
            Assert.AreEqual(123, testCola.darItems()[0]);
            Assert.AreEqual(456, testCola.darItems()[1]);
            Assert.AreEqual(789, testCola.darItems()[2]);
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestRevisarEnTADLleno()
            {
            #region Configurar
            testCola = new clsColaVector<int>();
            testItems = new int[3];
            testItems[0] = 123;
            testItems[1] = 456;
            testItems[2] = 789;
            testCola.ponerItems(testItems);
            testItem = 0;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testCola.revisar(ref testItem));
            Assert.AreEqual(123, testItem);
            Assert.AreEqual(3, testCola.darLongitud());
            Assert.AreEqual(3, testCola.darCapacidad());
            Assert.AreEqual(3, testCola.darItems().Length);
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            Assert.AreEqual(123, testCola.darItems()[0]);
            Assert.AreEqual(456, testCola.darItems()[1]);
            Assert.AreEqual(789, testCola.darItems()[2]);
            #endregion
            }
        #endregion
        #region Reversar
        [TestMethod]
        public void testReversarConTADSemilleno()
            {
            #region Inicializar
            testCola = new clsColaVector<int>(5);
            testCola.encolar(1);
            testCola.encolar(2);
            testCola.encolar(3);
            testCola.encolar(4);
            testItems = new int[5] { 4, 3, 2, 1, 0 };
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testCola.reversar());
            Assert.AreEqual(4, testCola.darLongitud());
            Assert.AreEqual(5, testCola.darCapacidad());
            Assert.AreEqual(5, testCola.darItems().Length);
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testCola.darItems());
            #endregion
            }
        [TestMethod]
        public void testReversarConTADLLeno()
            {
            #region Inicializar
            testCola = new clsColaVector<int>(4);
            testItems = new int[4] { 1, 2, 3, 4 };
            testCola.ponerItems(testItems);
            testItems = new int[4] { 4, 3, 2, 1 };
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testCola.reversar());
            Assert.AreEqual(4, testCola.darLongitud());
            Assert.AreEqual(4, testCola.darCapacidad());
            Assert.AreEqual(4, testCola.darItems().Length);
            Assert.AreEqual(true, testCola.esDinamica());
            Assert.AreEqual(1000, testCola.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testCola.darItems());
            #endregion
            }
        [TestMethod]
        public void testReversarConTADVacio()
            {
            #region Inicializar
            testItems = new int[4] { 0, 0, 0, 0 };
            testCola = new clsColaVector<int>(4);
            #endregion
            #region Comprobar y Comprobar
            Assert.AreEqual(false, testCola.reversar());
            Assert.AreEqual(0, testCola.darLongitud());
            Assert.AreEqual(4, testCola.darCapacidad());
            Assert.AreEqual(4, testCola.darItems().Length);
            Assert.AreEqual(true, testCola.esDinamica());
            CollectionAssert.AreEqual(testItems, testCola.darItems());
            #endregion
            }
        #endregion
        #endregion
        #endregion
        }
    }
