using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Colecciones.Enlazadas;

namespace uTestDemoColecciones
    {
    [TestClass]
    public class uTestPilaEnlazada
        {
        #region Atributos de Prueba
        private clsPilaEnlazada<int> testTAD;
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
            testTAD = new clsPilaEnlazada<int>();
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
            testTAD = new clsPilaEnlazada<int>();
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
            testTAD = new clsPilaEnlazada<int>();
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
            testTAD = new clsPilaEnlazada<int>();
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
            testTAD = new clsPilaEnlazada<int>();
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
            testTAD = new clsPilaEnlazada<int>();
            testItems = new int[3] { 1, 2, 3 };
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreNotEqual(null, testTAD.darItems());
            Assert.AreEqual(3, testTAD.darItems().Length);
            Assert.AreEqual(1, testTAD.darItems()[0]);
            Assert.AreEqual(2, testTAD.darItems()[1]);
            Assert.AreEqual(3, testTAD.darItems()[2]);
            #endregion
            }
        [TestMethod]
        public void uTestDarLongitud()
            {
            #region Configurar
            testTAD = new clsPilaEnlazada<int>();
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
        #region Apilar
        [TestMethod]
        public void uTestApilarItemEnTADVacio()
            {
            #region Configurar
            testTAD = new clsPilaEnlazada<int>();
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.apilar(123));
            Assert.AreEqual(123, testTAD.darItems()[0]);
            Assert.AreEqual(1, testTAD.darLongitud());
            #endregion
            }
        [TestMethod]
        public void uTestApilarItemEnTADConItems()
            {
            #region Configurar
            testTAD = new clsPilaEnlazada<int>();
            testItems = new int[3];
            testItems[0] = 789;
            testItems[1] = 456;
            testItems[2] = 123;
            testTAD.ponerItems(testItems);

            testItems = new int[4];
            testItems[0] = 777;
            testItems[1] = 789;
            testItems[2] = 456;
            testItems[3] = 123;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.apilar(777));
            Assert.AreEqual(4, testTAD.darLongitud());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestApilarItemEnTADConItemsEnBorde()
            {
            #region Configurar
            testTAD = new clsPilaEnlazada<int>();
            testItems = new int[int.MaxValue / 16];
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.apilar(777));
            Assert.AreEqual(int.MaxValue / 16, testTAD.darLongitud());
            Assert.AreEqual(int.MaxValue / 16, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #region Desapilar
        [TestMethod]
        public void uTestDesapilarEnTADVacio()
            {
            #region Configurar
            testTAD = new clsPilaEnlazada<int>();
            testItem = -1;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.desapilar(ref testItem));
            Assert.AreEqual(0, testItem);
            Assert.AreEqual(0, testTAD.darLongitud());
            Assert.AreEqual(null, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestDesapilarEnTADConItems()
            {
            #region Configurar
            testTAD = new clsPilaEnlazada<int>();
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
            Assert.AreEqual(true, testTAD.desapilar(ref testItem));
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
            testTAD = new clsPilaEnlazada<int>();
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
            testTAD = new clsPilaEnlazada<int>();
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
            testTAD = new clsPilaEnlazada<int>();
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
            testTAD = new clsPilaEnlazada<int>();
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
