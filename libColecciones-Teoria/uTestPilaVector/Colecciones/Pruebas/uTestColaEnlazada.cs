using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Colecciones.Enlazadas;

namespace uTestDemoColecciones
    {
    [TestClass]
    public class uTestColaEnlazada
        {
        #region Atributos de Prueba
        private clsColaEnlazada<int> testTAD;
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
            testTAD = new clsColaEnlazada<int>();
            Assert.AreEqual(null, testTAD.darItems());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(null, testTAD.darPrimero());
            Assert.AreEqual(null, testTAD.darUltimo());
            #endregion
            }
        #endregion
        #endregion
        #region Mutadores
        [TestMethod]
        public void uTestPonerItemsConLongitudCero()
            {
            #region Configurar
            testTAD = new clsColaEnlazada<int>();
            testItems = new int[0];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.ponerItems(testItems));
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(null, testTAD.darPrimero());
            Assert.AreEqual(null, testTAD.darUltimo());
            #endregion
            }
        [TestMethod]
        public void uTestPonerItemsConLongitudNormal()
            {
            #region Configurar
            testTAD = new clsColaEnlazada<int>();
            testItems = new int[3] { 1, 2, 3 };
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.ponerItems(testItems));
            Assert.AreEqual(3, testTAD.darLongitud());
            Assert.AreEqual(3, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestPonerItemsConLongitudEnBorde()
            {
            #region Configurar
            testTAD = new clsColaEnlazada<int>();
            testItems = new int[int.MaxValue / 16];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.ponerItems(testItems));
            Assert.AreEqual(int.MaxValue / 16, testTAD.darLongitud());
            Assert.AreEqual(int.MaxValue / 16, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestPonerItemsConLongitudMasAllaDelBorde()
            {
            #region Configurar
            testTAD = new clsColaEnlazada<int>();
            testItems = new int[int.MaxValue / 16 + 1];
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.ponerItems(testItems));
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(null, testTAD.darItems());
            #endregion
            }
        #endregion
        #region Accesores
        [TestMethod]
        public void uTestDarItems()
            {
            #region Configurar
            testTAD = new clsColaEnlazada<int>();
            testItems = new int[3] { 1, 2, 3 };
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(3, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestDarLongitud()
            {
            #region Configurar
            testTAD = new clsColaEnlazada<int>();
            testItems = new int[3] { 1, 2, 3 };
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(3, testTAD.darLongitud());
            #endregion
            }
        #endregion
        #region Consultores
        #endregion
        #region CRUDs
        #region Encolar
        [TestMethod]
        public void uTestEncolarItemEnTADVacio()
            {
            #region Configurar
            testTAD = new clsColaEnlazada<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.encolar(123));
            Assert.AreEqual(123, testTAD.darItems()[0]);
            Assert.AreEqual(1, testTAD.darLongitud());
            #endregion
            }
        [TestMethod]
        public void uTestEncolarItemEnTADConItems()
            {
            #region Configurar
            testTAD = new clsColaEnlazada<int>();
            testItems = new int[3];
            testItems[0] = 789;
            testItems[1] = 456;
            testItems[2] = 123;
            testTAD.ponerItems(testItems);

            testItems = new int[4];
            testItems[0] = 789;
            testItems[1] = 456;
            testItems[2] = 123;
            testItems[3] = 777;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.encolar(777));
            Assert.AreEqual(4, testTAD.darLongitud());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestEncolarItemEnTADConItemsEnBorde()
            {
            #region Configurar
            testTAD = new clsColaEnlazada<int>();
            testItems = new int[int.MaxValue / 16];
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.encolar(777));
            Assert.AreEqual(int.MaxValue / 16, testTAD.darLongitud());
            Assert.AreEqual(int.MaxValue / 16, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #region Desencolar
        [TestMethod]
        public void uTestDesencolarEnTADVacio()
            {
            #region Configurar
            testTAD = new clsColaEnlazada<int>();
            testItem = -1;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.desencolar(ref testItem));
            Assert.AreEqual(0, testItem);
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(null, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestDesencolarEnTADConItems()
            {
            #region Configurar
            testTAD = new clsColaEnlazada<int>();
            testItems = new int[3];
            testItems[0] = 123;
            testItems[1] = 456;
            testItems[2] = 789;
            testTAD.ponerItems(testItems);

            testItems = new int[2];
            testItems[0] = 456;
            testItems[1] = 789;
            testItem=-1;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.desencolar(ref testItem));
            Assert.AreEqual(123, testItem);
            Assert.AreEqual(2, testTAD.darLongitud());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #region Revisar
        [TestMethod]
        public void uTestRevisarEnTADVacio()
            {
            #region Configurar
            testTAD = new clsColaEnlazada<int>();
            testItems = new int[0];
            testItem = -1;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.revisar(ref testItem));
            Assert.AreEqual(0, testItem);
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(null, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRevisarEnTADConItems()
            {
            #region Configurar
            testTAD = new clsColaEnlazada<int>();
            testItems = new int[3];
            testItems[0] = 123;
            testItems[1] = 456;
            testItems[2] = 789;
            testTAD.ponerItems(testItems);
            testItem=-1;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.revisar(ref testItem));
            Assert.AreEqual(123, testItem);
            Assert.AreEqual(3, testTAD.darLongitud());
            Assert.AreEqual(3, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #region Reversar
        [TestMethod]
        public void testReversarEnTADConItems()
            {
            #region Inicializar
            testTAD = new clsColaEnlazada<int>();
            testItems = new int[4] { 1, 2, 3, 4 };
            testTAD.ponerItems(testItems);
            testItems = new int[4] { 4, 3, 2, 1 };
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.reversar());
            Assert.AreEqual(4, testTAD.darLongitud());
            Assert.AreEqual(4, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void testReversarConTADVacio()
            {
            #region Inicializar
            testTAD = new clsColaEnlazada<int>();
            #endregion
            #region Comprobar y Comprobar
            Assert.AreEqual(false, testTAD.reversar());
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(null, testTAD.darItems());
            #endregion
            }
        #endregion
        #endregion
        #endregion
        }
    }
