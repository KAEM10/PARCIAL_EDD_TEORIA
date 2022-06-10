using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Colecciones.Vectoriales;
using System.Collections.Generic;

namespace uTestDemoColecciones
    {
    [TestClass]
    public class utestListaVector
        {
        #region Atributos de Prueba
        private clsListaVector<int> testLista;
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
            testLista = new clsListaVector<int>();
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
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
            testLista = new clsListaVector<int>(-100);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor1CapacidadCero()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(0);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor1CapacidadNormal()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(500);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(500, testLista.darItems().Length);
            Assert.AreEqual(500, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor1CapacidadEnBorde()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(int.MaxValue / 16);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(int.MaxValue / 16, testLista.darItems().Length);
            Assert.AreEqual(int.MaxValue / 16, testLista.darCapacidad());
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor1CapacidadFueraDeBorde()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(int.MaxValue / 16 + 1);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor1CapacidadEnMaxValue()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(int.MaxValue);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
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
            testLista = new clsListaVector<int>(-100, true);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadNegativaNOFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(-100, false);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadCeroFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(0, true);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadCeroNOFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(0, false);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadNormalFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(500, true);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(500, testLista.darItems().Length);
            Assert.AreEqual(500, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadNormalNOFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(500, false);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(500, testLista.darItems().Length);
            Assert.AreEqual(500, testLista.darCapacidad());
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadMasAllaBordeFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(int.MaxValue / 16 + 1, true);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadMasAllaBordeNOFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(int.MaxValue / 16 + 1, false);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadEnMaxValueFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(int.MaxValue, true);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor2CapacidadEnMaxValueNOFlexible()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(int.MaxValue, false);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
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
            testLista = new clsListaVector<int>(-100, -10);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadNegativaFactorCrecimientoCero()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(-100, 0);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadNegativaFactorCrecimientoNormal()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(-100, 10);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadNegativaFactorCrecimientoMasAllaBorde()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(-100, int.MaxValue / 16 + 1);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }

        [TestMethod]
        public void uTestConstructor3CapacidadCeroFactorCrecimientoNegativo()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(0, -1);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadCeroFactorCrecimientoCero()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(0, 0);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadCeroFactorCrecimientoNormal()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(0, 500);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(500, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadCeroFactorCrecimientoMasAllaBorde()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(0, int.MaxValue / 16 + 1);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }

        [TestMethod]
        public void uTestConstructor3CapacidadNormalFactorCrecimientoNegativo()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(500, -1);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadNormalFactorCrecimientoCero()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(500, 0);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(500, testLista.darItems().Length);
            Assert.AreEqual(500, testLista.darCapacidad());
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadNormalFactorCrecimientoNormal()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(500, 500);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(500, testLista.darItems().Length);
            Assert.AreEqual(500, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(500, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadNormalFactorCrecimientoMasAllaBorde()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(500, int.MaxValue / 16 + 1);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(00, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }

        [TestMethod]
        public void uTestConstructor3CapacidadEnBordeFactoCrecimientoNegativo()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(int.MaxValue / 16, -1);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadEnBordeFactoCrecimientoCero()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(int.MaxValue / 16, 0);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(int.MaxValue / 16, testLista.darItems().Length);
            Assert.AreEqual(int.MaxValue / 16, testLista.darCapacidad());
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadEnBordeFactoCrecimientoNormal()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(int.MaxValue / 16, 500);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadEnBordeFactoCrecimientoMasAllaBorde()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(int.MaxValue / 16, int.MaxValue / 16 + 1);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }

        [TestMethod]
        public void uTestConstructor3CapacidadFueraDeBordeFactorCrecimientoNegativo()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(int.MaxValue / 16 + 1, -1);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadFueraDeBordeFactorCrecimientoCero()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(int.MaxValue / 16 + 1, 0);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadFueraDeBordeFactorCrecimientoNormal()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(int.MaxValue / 16 + 1, 500);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadFueraDeBordeFactorCrecimientoMasAllaBorde()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(int.MaxValue / 16 + 1, int.MaxValue / 16 + 1);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }

        [TestMethod]
        public void uTestConstructor3CapacidadEnMaxValueFactorCrecimientoNegativo()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(int.MaxValue, -1);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadEnMaxValueFactorCrecimientoCero()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(int.MaxValue, 0);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadEnMaxValueBordeFactorCrecimientoNormal()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(int.MaxValue, 500);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestConstructor3CapacidadEnMaxValueFactorCrecimientoMasAllaBorde()
            {
            #region Configurar
            #endregion
            #region Probar y Comprobar
            testLista = new clsListaVector<int>(int.MaxValue, int.MaxValue / 16 + 1);
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        #endregion
        #endregion
        #region Mutadores
        [TestMethod]
        public void uTestPonerItemsConLongitudCero()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[0];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.ponerItems(testItems));
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        [TestMethod]
        public void uTestPonerItemsConLongitudNormal()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.ponerItems(testItems));
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1, testLista.darItems()[0]);
            Assert.AreEqual(2, testLista.darItems()[1]);
            Assert.AreEqual(3, testLista.darItems()[2]);
            Assert.AreEqual(3, testLista.darItems().Length);
            #endregion
            }
        [TestMethod]
        public void uTestPonerItemsConLongitudEnBorde()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[int.MaxValue / 16];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.ponerItems(testItems));
            Assert.AreEqual(int.MaxValue / 16, testLista.darCapacidad());
            Assert.AreEqual(int.MaxValue / 16, testLista.darLongitud());
            Assert.AreEqual(int.MaxValue / 16, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestPonerItemsConLongitudMasAllaDelBorde()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[int.MaxValue / 16 + 1];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.ponerItems(testItems));
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darItems().Length);
            #endregion
            }

        [TestMethod]
        public void uTestAjustarFlexibilidadCapacidadEnBorde()
            {
            #region Configurar
            testLista = new clsListaVector<int>(int.MaxValue / 16);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.ajustarFlexibilidad(true));
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(int.MaxValue / 16, testLista.darCapacidad());
            Assert.AreEqual(int.MaxValue / 16, testLista.darItems().Length);
            #endregion
            }
        [TestMethod]
        public void uTestAjustaFlexibilidadCapacidadEnCero()
            {
            #region Configurar
            testLista = new clsListaVector<int>(0);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.ajustarFlexibilidad(false));
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(0, testLista.darItems().Length);
            #endregion
            }
        [TestMethod]
        public void uTestAjustarFlexibilidadCapacidadNormal()
            {
            #region Configurar
            testLista = new clsListaVector<int>(500);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.ajustarFlexibilidad(false));
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(500, testLista.darCapacidad());
            Assert.AreEqual(500, testLista.darItems().Length);
            #endregion
            }

        [TestMethod]
        public void uTestAjustarFactorCrecimientoNormalEnCapacidadNormal()
            {
            #region Configurar
            testLista = new clsListaVector<int>(500);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.ajustarFactorCrecimiento(3000));
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(3000, testLista.darFactorCrecimiento());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(500, testLista.darCapacidad());
            Assert.AreEqual(500, testLista.darItems().Length);
            #endregion
            }
        [TestMethod]
        public void uTestAjustarFactorCrecimientoEnBordeEnCapacidadNormal()
            {
            #region Configurar
            testLista = new clsListaVector<int>(500);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.ajustarFactorCrecimiento((int.MaxValue / 16) - testLista.darItems().Length));
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(int.MaxValue / 16 - testLista.darItems().Length, testLista.darFactorCrecimiento());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(500, testLista.darCapacidad());
            Assert.AreEqual(500, testLista.darItems().Length);
            #endregion
            }
        [TestMethod]
        public void uTestAjustarFactorCrecimientoEnBordeConCapacidadEnBorde()
            {
            #region Configurar
            testLista = new clsListaVector<int>(int.MaxValue / 16);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.ajustarFactorCrecimiento(int.MaxValue / 16));
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(int.MaxValue / 16, testLista.darCapacidad());
            Assert.AreEqual(int.MaxValue / 16, testLista.darItems().Length);
            #endregion
            }
        #endregion
        #region Accesores
        [TestMethod]
        public void uTestDarItems()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreNotEqual(null, testLista.darItems());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(1, testLista.darItems()[0]);
            Assert.AreEqual(2, testLista.darItems()[1]);
            Assert.AreEqual(3, testLista.darItems()[2]);
            #endregion
            }
        [TestMethod]
        public void uTestDarLongitud()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(3, testLista.darLongitud());
            #endregion
            }
        [TestMethod]
        public void uTestDarCapacidad()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(3, testLista.darCapacidad());
            #endregion
            }
        [TestMethod]
        public void uTestDarFactorCrecimiento()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            #endregion
            }
        #endregion
        #region Consultores
        [TestMethod]
        public void uTestEsDinamica()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.esDinamica());
            #endregion
            }
        #endregion
        #region CRUDs
        #region Agregar
        [TestMethod]
        public void uTestAgregarItemEnListaVacia()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[1000];
            testItems[0] = 123;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.agregar(123));
            Assert.AreEqual(123, testLista.darItems()[0]);
            Assert.AreEqual(1, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestAgregarItemEnListaLlena()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3];
            testItems[0] = 123;
            testItems[1] = 456;
            testItems[2] = 789;
            testLista.ponerItems(testItems);
            testItems = new int[1003]; //Fixed
            testItems[0] = 123;
            testItems[1] = 456;
            testItems[2] = 789;
            testItems[3] = 777;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.agregar(777));
            Assert.AreEqual(4, testLista.darLongitud());
            Assert.AreEqual(1003, testLista.darCapacidad());
            Assert.AreEqual(1003, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestAgregarItemEnListaLlenaEnBorde()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[int.MaxValue / 16];
            testLista.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.agregar(777));
            Assert.AreEqual(int.MaxValue / 16, testLista.darLongitud());
            Assert.AreEqual(int.MaxValue / 16, testLista.darCapacidad());
            Assert.AreEqual(int.MaxValue / 16, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestAgregarItemEnListaConItems()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(123);
            testItems = new int[1000];
            testItems[0] = 123;
            testItems[1] = 456;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.agregar(456));
            Assert.AreEqual(2, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        #endregion
        #region Insertar Item en Indice
        #region Indice Negativo
        [TestMethod]
        public void uTestInsertarItemConIndiceNegativoConTADVacioFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[0];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.insertarEn(-1, 4));
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemConIndiceNegativoConTADVacioEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.ajustarFlexibilidad(false);
            testItems = new int[0];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.insertarEn(-1, 4));
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());   //Fixed
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemConIndiceNegativoConTADLlenoFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testItems = new int[3]; //Fixed
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.insertarEn(-1, 4));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());  //Fixed
            Assert.AreEqual(3, testLista.darItems().Length); //Fixed
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemConIndiceNegativoConTADLlenoEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.insertarEn(-1, 4));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemConIndiceNegativoEnTADConItemsFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.insertarEn(-1, 4));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemConIndiceNegativoEnTADConItemsEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.insertarEn(-1, 4));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        #endregion
        #region Indice Cero
        [TestMethod]
        public void uTestInsertarItemEnIndiceCeroConTADVacioFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[1000];
            testItems[0] = 4;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.insertarEn(0, 4));
            Assert.AreEqual(1, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemEnIndiceCeroConTADVacioEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>(1000);
            testLista.ajustarFlexibilidad(false);
            testItems = new int[1000];
            testItems[0] = 4;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.insertarEn(0, 4));
            Assert.AreEqual(1, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemEnIndiceCeroConTADLlenoFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testItems = new int[1003];
            testItems[0] = 4;
            testItems[1] = 1;
            testItems[2] = 2;
            testItems[3] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.insertarEn(0, 4));
            Assert.AreEqual(4, testLista.darLongitud());
            Assert.AreEqual(1003, testLista.darCapacidad());
            Assert.AreEqual(1003, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemEnIndiceCeroConTADLlenoEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.insertarEn(0, 4));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemEnIndiceCeroEnTADConItemsFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 4;
            testItems[1] = 1;
            testItems[2] = 2;
            testItems[3] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.insertarEn(0, 4));
            Assert.AreEqual(4, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemEnIndiceCeroEnTADConItemsEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 4;
            testItems[1] = 1;
            testItems[2] = 2;
            testItems[3] = 3;
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.insertarEn(0, 4));
            Assert.AreEqual(4, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        #endregion
        #region Indice Mayor a Cero Menor que Longitud
        [TestMethod]
        public void uTestInsertarItemEnIndiceConTADVacioFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>(1000);
            testItems = new int[1000];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.insertarEn(2, 4));
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemEnIndiceConTADVacioEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>(1000);
            testLista.ajustarFlexibilidad(false);
            testItems = new int[1000];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.insertarEn(2, 4));
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemEnIndiceConTADLlenoFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testItems = new int[1003];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 4;
            testItems[3] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.insertarEn(2, 4));
            Assert.AreEqual(4, testLista.darLongitud());
            Assert.AreEqual(1003, testLista.darCapacidad());
            Assert.AreEqual(1003, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemEnIndiceConTADLlenoEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.insertarEn(2, 4));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemEnIndiceEnTADConItemsFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 4;
            testItems[3] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.insertarEn(2, 4));
            Assert.AreEqual(4, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemEnIndiceEnTADConItemsEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 4;
            testItems[3] = 3;
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.insertarEn(2, 4));
            Assert.AreEqual(4, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        #endregion
        #region Indice igual a Longitud
        [TestMethod]
        public void uTestInsertarItemEnLongitudConTADVacioFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[1000];
            testItems[0] = 4;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.insertarEn(0, 4));
            Assert.AreEqual(1, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemEnLongitudConTADVacioEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>(1000);
            testLista.ajustarFlexibilidad(false);
            testItems = new int[1000];
            testItems[0] = 4;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.insertarEn(0, 4));
            Assert.AreEqual(1, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemEnLongitudConTADLlenoFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testItems = new int[1003];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testItems[3] = 4;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.insertarEn(3, 4));
            Assert.AreEqual(4, testLista.darLongitud());
            Assert.AreEqual(1003, testLista.darCapacidad());
            Assert.AreEqual(1003, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemEnLongitudConTADLlenoEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.insertarEn(3, 4));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemEnLongitudEnTADConItemsFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testItems[3] = 4;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.insertarEn(3, 4));
            Assert.AreEqual(4, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemEnLongitudEnTADConItemsEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testItems[3] = 4;
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.insertarEn(3, 4));
            Assert.AreEqual(4, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        #endregion
        #region Indice Más allá de Longitud
        [TestMethod]
        public void uTestInsertarItemMasAllaDeLongitudConTADVacioFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[0];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.insertarEn(4, 4));
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemMasAllaDeLongitudConTADVacioEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>(1000);
            testLista.ajustarFlexibilidad(false);
            testItems = new int[1000];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.insertarEn(4, 4));
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemMasAllaDeLongitudConTADLlenoFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems); //Fixed
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.insertarEn(4, 4));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());//Fixed
            Assert.AreEqual(3, testLista.darItems().Length);//Fixed
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarMasAllaDeLongitudConTADLlenoEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.insertarEn(4, 4));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemMasAllaDeLongitudEnTADConItemsFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.insertarEn(4, 4));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemMasAllaDeLongitudEnTADConItemsEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.insertarEn(4, 4));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        #endregion
        #endregion
        #region Extraer Item en Indice
        #region Indice Negativo
        [TestMethod]
        public void uTestExtraerItemConIndiceNegativoConTADVacioFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[0];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.extraerEn(-1, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemConIndiceNegativoConTADVacioEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>(5); //Fixed
            testLista.ajustarFlexibilidad(false);
            testItems = new int[5]; //Fixed
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.extraerEn(-1, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(5, testLista.darCapacidad()); //Fixed
            Assert.AreEqual(5, testLista.darItems().Length);//Fixed
            Assert.AreEqual(false, testLista.esDinamica());//Fixed
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemConIndiceNegativoConTADLlenoFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.extraerEn(-1, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemConIndiceNegativoConTADLlenoEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.extraerEn(-1, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemConIndiceNegativoEnTADConItemsFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.extraerEn(-1,ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemConIndiceNegativoEnTADConItemsEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.extraerEn(-1, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        #endregion
        #region Indice Cero
        [TestMethod]
        public void uTestExtraerItemEnIndiceCeroConTADVacioFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>(1000);
            testItems = new int[1000];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.extraerEn(0, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemEnIndiceCeroConTADVacioEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>(1000);
            testLista.ajustarFlexibilidad(false);
            testItems = new int[1000];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.extraerEn(0, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemEnIndiceCeroConTADLlenoFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testItems = new int[3] { 2, 3, 3 };
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.extraerEn(0,ref testItem));
            Assert.AreEqual(1, testItem);
            Assert.AreEqual(2, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemEnIndiceCeroConTADLlenoEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testLista.ajustarFlexibilidad(false);
            testItems = new int[3] {2, 3, 3 };
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.extraerEn(0, ref testItem));
            Assert.AreEqual(1, testItem);
            Assert.AreEqual(2, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemEnIndiceCeroEnTADConItemsFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 2;
            testItems[1] = 3;
            testItems[2] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.extraerEn(0, ref testItem));
            Assert.AreEqual(1, testItem);
            Assert.AreEqual(2, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemEnIndiceCeroEnTADConItemsEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testLista.ajustarFlexibilidad(false);
            testItems = new int[1000];
            testItems[0] = 2;
            testItems[1] = 3;
            testItems[2] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.extraerEn(0, ref testItem));
            Assert.AreEqual(1, testItem);
            Assert.AreEqual(2, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        #endregion
        #region Indice Mayor a Cero Menor que Longitud
        [TestMethod]
        public void uTestExtraerItemEnIndiceConTADVacioFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>(1000);
            testItems = new int[1000];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.extraerEn(2, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemEnIndiceConTADVacioEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>(1000);
            testLista.ajustarFlexibilidad(false);
            testItems = new int[1000];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.extraerEn(2, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemEnIndiceConTADLlenoFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testItems = new int[3] { 1, 2, 3 };
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.extraerEn(2, ref testItem));
            Assert.AreEqual(3, testItem);
            Assert.AreEqual(2, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemEnIndiceConTADLlenoEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testLista.ajustarFlexibilidad(false);
            testItems = new int[3] { 1, 2, 3 };
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.extraerEn(2, ref testItem));
            Assert.AreEqual(3, testItem);
            Assert.AreEqual(2, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemEnIndiceEnTADConItemsFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.extraerEn(2, ref testItem));
            Assert.AreEqual(3, testItem);
            Assert.AreEqual(2, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemEnIndiceEnTADConItemsEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.extraerEn(2, ref testItem));
            Assert.AreEqual(3, testItem);
            Assert.AreEqual(2, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        #endregion
        #region Indice igual a Longitud
        [TestMethod]
        public void uTestExtraerItemEnLongitudConTADVacioFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[0];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.extraerEn(0, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemEnLongitudConTADVacioEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>(1000);
            testLista.ajustarFlexibilidad(false);
            testItems = new int[1000];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.extraerEn(0, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemEnLongitudConTADLlenoFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testItems = new int[3] { 1, 2, 3 };
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.extraerEn(3, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemEnLongitudConTADLlenoEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.extraerEn(3, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemEnLongitudEnTADConItemsFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.extraerEn(3,ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemEnLongitudEnTADConItemsEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.extraerEn(3, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        #endregion
        #region Indice Más allá de Longitud
        [TestMethod]
        public void uTestExtraerItemMasAllaDeLongitudConTADVacioFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[0];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.extraerEn(4, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemMasAllaDeLongitudConTADVacioEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>(1000);
            testLista.ajustarFlexibilidad(false);
            testItems = new int[1000];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.extraerEn(4, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemMasAllaDeLongitudConTADLlenoFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.extraerEn(4, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemMasAllaDeLongitudConTADLlenoEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.extraerEn(4, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemMasAllaDeLongitudEnTADConItemsFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.extraerEn(4, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemMasAllaDeLongitudEnTADConItemsEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.extraerEn(4, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        #endregion
        #endregion
        #region Modificar Item en Indice
        #region Indice Negativo
        [TestMethod]
        public void uTestModificarItemConIndiceNegativoConTADVacioFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[0];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.modificarEn(-1, 777));
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemConIndiceNegativoConTADVacioEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>(5); //Fixed
            testLista.ajustarFlexibilidad(false);
            testItems = new int[5];//Fixed
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.modificarEn(-1, 777));
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(5, testLista.darCapacidad());//Fixed
            Assert.AreEqual(5, testLista.darItems().Length);//Fixed
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemConIndiceNegativoConTADLlenoFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.modificarEn(-1, 777));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemConIndiceNegativoConTADLlenoEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.modificarEn(-1, 777));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemConIndiceNegativoEnTADConItemsFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.modificarEn(-1, 777));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemConIndiceNegativoEnTADConItemsEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.modificarEn(-1, 777));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        #endregion
        #region Indice Cero
        [TestMethod]
        public void uTestModificarItemEnIndiceCeroConTADVacioFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>(1000);
            testItems = new int[1000];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.modificarEn(0, 777));
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemEnIndiceCeroConTADVacioEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>(1000);
            testLista.ajustarFlexibilidad(false);
            testItems = new int[1000];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.modificarEn(0, 777));
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemEnIndiceCeroConTADLlenoFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testItems = new int[3] { 777, 2, 3 };
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.modificarEn(0, 777));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemEnIndiceCeroConTADLlenoEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testItems = new int[3] { 777, 2, 3 };
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.modificarEn(0, 777));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemEnIndiceCeroEnTADConItemsFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 777;
            testItems[1] = 2;
            testItems[2] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.modificarEn(0, 777));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemEnIndiceCeroEnTADConItemsEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testLista.ajustarFlexibilidad(false);
            testItems = new int[1000];
            testItems[0] = 777;
            testItems[1] = 2;
            testItems[2] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.modificarEn(0, 777));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        #endregion
        #region Indice Mayor a Cero Menor que Longitud
        [TestMethod]
        public void uTestModificarItemEnIndiceConTADVacioFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>(1000);
            testItems = new int[1000];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.modificarEn(2, 777));
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemEnIndiceConTADVacioEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>(1000);
            testLista.ajustarFlexibilidad(false);
            testItems = new int[1000];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.modificarEn(2, 777));
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemEnIndiceConTADLlenoFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testItems = new int[3] { 1, 2, 777 };
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.modificarEn(2, 777));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemEnIndiceConTADLlenoEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testLista.ajustarFlexibilidad(false);
            testItems = new int[3] { 1, 2, 777 };
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.modificarEn(2, 777));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemEnIndiceEnTADConItemsFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 777;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.modificarEn(2, 777));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemEnIndiceEnTADConItemsEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 777;
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.modificarEn(2, 777));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        #endregion
        #region Indice igual a Longitud
        [TestMethod]
        public void uTestModificarItemEnLongitudConTADVacioFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[0];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.modificarEn(0, 777));
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemEnLongitudConTADVacioEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>(1000);
            testLista.ajustarFlexibilidad(false);
            testItems = new int[1000];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.modificarEn(0, 777));
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemEnLongitudConTADLlenoFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.modificarEn(3, 777));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemEnLongitudConTADLlenoEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.modificarEn(3, 777));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemEnLongitudEnTADConItemsFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.modificarEn(3, 777));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemEnLongitudEnTADConItemsEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.modificarEn(3, 777));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        #endregion
        #region Indice Más allá de Longitud
        [TestMethod]
        public void uTestModificarItemMasAllaDeLongitudConTADVacioFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[0];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.modificarEn(4, 777));
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemMasAllaDeLongitudConTADVacioEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>(1000);
            testLista.ajustarFlexibilidad(false);
            testItems = new int[1000];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.modificarEn(4, 777));
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemMasAllaDeLongitudConTADLlenoFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.modificarEn(4, 777));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemMasAllaDeLongitudConTADLlenoEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.modificarEn(4, 777));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemMasAllaDeLongitudEnTADConItemsFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.modificarEn(4, 777));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemMasAllaDeLongitudEnTADConItemsEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.modificarEn(4, 777));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        #endregion
        #endregion
        #region Recuperar Item en Indice
        #region Indice Negativo
        [TestMethod]
        public void uTestRecuperarItemConIndiceNegativoConTADVacioFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[0];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.recuperarEn(-1, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemConIndiceNegativoConTADVacioEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>(5); //Fixed
            testLista.ajustarFlexibilidad(false);
            testItems = new int[5]; //Fixed
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.recuperarEn(-1, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(5, testLista.darCapacidad());
            Assert.AreEqual(5, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemConIndiceNegativoConTADLlenoFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.recuperarEn(-1, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemConIndiceNegativoConTADLlenoEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.recuperarEn(-1, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemConIndiceNegativoEnTADConItemsFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.recuperarEn(-1, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemConIndiceNegativoEnTADConItemsEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.recuperarEn(-1, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        #endregion
        #region Indice Cero
        [TestMethod]
        public void uTestRecuperarItemEnIndiceCeroConTADVacioFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>(1000);
            testItems = new int[1000];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.recuperarEn(0, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemEnIndiceCeroConTADVacioEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>(1000);
            testLista.ajustarFlexibilidad(false);
            testItems = new int[1000];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.recuperarEn(0, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemEnIndiceCeroConTADLlenoFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.recuperarEn(0, ref testItem));
            Assert.AreEqual(1, testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemEnIndiceCeroConTADLlenoEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.recuperarEn(0, ref testItem));
            Assert.AreEqual(1, testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemEnIndiceCeroEnTADConItemsFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.recuperarEn(0, ref testItem));
            Assert.AreEqual(1, testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemEnIndiceCeroEnTADConItemsEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testLista.ajustarFlexibilidad(false);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.recuperarEn(0, ref testItem));
            Assert.AreEqual(1, testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        #endregion
        #region Indice Mayor a Cero Menor que Longitud
        [TestMethod]
        public void uTestRecuperarItemEnIndiceConTADVacioFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>(1000);
            testItems = new int[1000];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.recuperarEn(2, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemEnIndiceConTADVacioEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>(1000);
            testLista.ajustarFlexibilidad(false);
            testItems = new int[1000];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.recuperarEn(2, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemEnIndiceConTADLlenoFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.recuperarEn(2, ref testItem));
            Assert.AreEqual(3, testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemEnIndiceConTADLlenoEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.recuperarEn(2, ref testItem));
            Assert.AreEqual(3, testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemEnIndiceEnTADConItemsFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.recuperarEn(2, ref testItem));
            Assert.AreEqual(3, testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemEnIndiceEnTADConItemsEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.recuperarEn(2, ref testItem));
            Assert.AreEqual(3, testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        #endregion
        #region Indice igual a Longitud
        [TestMethod]
        public void uTestRecuperarItemEnLongitudConTADVacioFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[0];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.recuperarEn(0, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemEnLongitudConTADVacioEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>(1000);
            testLista.ajustarFlexibilidad(false);
            testItems = new int[1000];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.recuperarEn(0, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemEnLongitudConTADLlenoFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.recuperarEn(3, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemEnLongitudConTADLlenoEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.recuperarEn(3, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemEnLongitudEnTADConItemsFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.recuperarEn(3, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemEnLongitudEnTADConItemsEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.recuperarEn(3, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        #endregion
        #region Indice Más allá de Longitud
        [TestMethod]
        public void uTestRecuperarItemMasAllaDeLongitudConTADVacioFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[0];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.recuperarEn(4, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemMasAllaDeLongitudConTADVacioEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>(1000);
            testLista.ajustarFlexibilidad(false);
            testItems = new int[1000];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.recuperarEn(4, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemMasAllaDeLongitudConTADLlenoFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.recuperarEn(4, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemMasAllaDeLongitudConTADLlenoEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[3] { 1, 2, 3 };
            testLista.ponerItems(testItems);
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.recuperarEn(4, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(3, testLista.darCapacidad());
            Assert.AreEqual(3, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemMasAllaDeLongitudEnTADConItemsFlexible()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.recuperarEn(4, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemMasAllaDeLongitudEnTADConItemsEstatico()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testLista.ajustarFlexibilidad(false);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.recuperarEn(4, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(false, testLista.esDinamica());
            Assert.AreEqual(0, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        #endregion
        #endregion
        #region Contiene Item
        [TestMethod]
        public void uTestContieneItemEnTADVacio()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[0];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.contieneA(0));
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestContieneItemEnTADConItems()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.contieneA(3));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestNoContieneItemEnTADItems()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testLista.contieneA(777));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        #endregion
        #region Encontrar Item
        [TestMethod]
        public void uTestEncontrarItemEnTADVacio()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testItems = new int[0];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(-1, testLista.encontrarA(0));
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(0, testLista.darCapacidad());
            Assert.AreEqual(0, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestEncontrarItemEnTADConItems()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(2, testLista.encontrarA(3));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestEncontrarItemEnTADConItemsVariasOcurrencias()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(2);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 2;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(1, testLista.encontrarA(2));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestEncontrarItemEnTADConItemsNingunaOcurrencia()
            {
            #region Configurar
            testLista = new clsListaVector<int>();
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testItems = new int[1000];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(-1, testLista.encontrarA(777));
            Assert.AreEqual(3, testLista.darLongitud());
            Assert.AreEqual(1000, testLista.darCapacidad());
            Assert.AreEqual(1000, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        #endregion
        #region Reversar
        [TestMethod]
        public void testReversarConTADSemilleno()
            {
            #region Inicializar
            testLista = new clsListaVector<int>(5);
            testLista.agregar(1);
            testLista.agregar(2);
            testLista.agregar(3);
            testLista.agregar(4);
            testItems = new int[5] { 4, 3, 2, 1, 0 };
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.reversar());
            Assert.AreEqual(4, testLista.darLongitud());
            Assert.AreEqual(5, testLista.darCapacidad());
            Assert.AreEqual(5, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void testReversarConTADLLeno()
            {
            #region Inicializar
            testLista = new clsListaVector<int>();
            testItems = new int[4] { 1, 2, 3, 4 };
            testLista.ponerItems(testItems);
            testItems = new int[4] { 4, 3, 2, 1 };
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testLista.reversar());
            Assert.AreEqual(4, testLista.darLongitud());
            Assert.AreEqual(4, testLista.darCapacidad());
            Assert.AreEqual(4, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            Assert.AreEqual(1000, testLista.darFactorCrecimiento());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        [TestMethod]
        public void testReversarConTADVacio()
            {
            #region Inicializar
            testItems = new int[4] { 0, 0, 0, 0 };
            testLista = new clsListaVector<int>(4);
            #endregion
            #region Comprobar y Comprobar
            Assert.AreEqual(false, testLista.reversar());
            Assert.AreEqual(0, testLista.darLongitud());
            Assert.AreEqual(4, testLista.darCapacidad());
            Assert.AreEqual(4, testLista.darItems().Length);
            Assert.AreEqual(true, testLista.esDinamica());
            CollectionAssert.AreEqual(testItems, testLista.darItems());
            #endregion
            }
        #endregion
        #endregion
        #endregion
        }
    }
