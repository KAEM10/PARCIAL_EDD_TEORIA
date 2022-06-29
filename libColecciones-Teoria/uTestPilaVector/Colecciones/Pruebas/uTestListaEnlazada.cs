using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Colecciones.Enlazadas;
using System.Collections.Generic;

namespace uTestDemoColecciones
    {
    [TestClass]
    public class utestListaEnlazada
        {
        #region Atributos de Prueba
        private clsListaEnlazada<int> testTAD;
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
            testTAD = new clsListaEnlazada<int>();
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
            testTAD = new clsListaEnlazada<int>();
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
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[3] { 1, 2, 3 };
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.ponerItems(testItems));
            Assert.AreEqual(3, testTAD.darLongitud());
            Assert.AreEqual(1, testTAD.darItems()[0]);
            Assert.AreEqual(2, testTAD.darItems()[1]);
            Assert.AreEqual(3, testTAD.darItems()[2]);
            Assert.AreEqual(3, testTAD.darItems().Length);
            #endregion
            }
        [TestMethod]
        public void uTestPonerItemsConLongitudEnBorde()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
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
            testTAD = new clsListaEnlazada<int>();
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
            testTAD = new clsListaEnlazada<int>();
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
            testTAD = new clsListaEnlazada<int>();
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
        #region Agregar
        [TestMethod]
        public void uTestAgregarItemEnListaVacia()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[1];
            testItems[0] = 123;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.agregar(123));
            Assert.AreEqual(123, testTAD.darItems()[0]);
            Assert.AreEqual(1, testTAD.darLongitud());
            Assert.AreEqual(1, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestAgregarItemEnListaConItems()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
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
            Assert.AreEqual(true, testTAD.agregar(777));
            Assert.AreEqual(4, testTAD.darLongitud());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestAgregarItemEnListaEnBorde()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[int.MaxValue / 16];
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.agregar(777));
            Assert.AreEqual(int.MaxValue / 16, testTAD.darLongitud());
            Assert.AreEqual(int.MaxValue / 16, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }

        #endregion
        #region Insertar Item en Indice
        #region Indice Negativo
        [TestMethod]
        public void uTestInsertarItemConIndiceNegativoEnTADVacio()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = null;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.insertar(-1, 4));
            Assert.AreEqual(0, testTAD.darLongitud());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemConIndiceNegativoEnTADConItems()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[3];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.insertar(-1, 4));
            Assert.AreEqual(3, testTAD.darLongitud());
            Assert.AreEqual(3, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #region Indice Cero
        [TestMethod]
        public void uTestInsertarItemEnIndiceCeroConTADVacio()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[1];
            testItems[0] = 4;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.insertar(0, 4));
            Assert.AreEqual(1, testTAD.darLongitud());
            Assert.AreEqual(1, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemEnIndiceCeroEnTADConItems()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[3];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testTAD.ponerItems(testItems);

            testItems = new int[4];
            testItems[0] = 4;
            testItems[1] = 1;
            testItems[2] = 2;
            testItems[3] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.insertar(0, 4));
            Assert.AreEqual(4, testTAD.darLongitud());
            Assert.AreEqual(4, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #region Indice Mayor a Cero Menor que Longitud
        [TestMethod]
        public void uTestInsertarItemEnIndiceConTADVacio()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = null;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.insertar(2, 4));
            Assert.AreEqual(0, testTAD.darLongitud());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemEnIndiceEnTADConItems()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[3];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testTAD.ponerItems(testItems);

            testItems = new int[4];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 4;
            testItems[3] = 3;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.insertar(2, 4));
            Assert.AreEqual(4, testTAD.darLongitud());
            Assert.AreEqual(4, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #region Indice igual a Longitud
        [TestMethod]
        public void uTestInsertarItemEnLongitudConTADVacio()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[1];
            testItems[0] = 4;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.insertar(0, 4));
            Assert.AreEqual(1, testTAD.darLongitud());
            Assert.AreEqual(1, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemEnLongitudEnTADConItems()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[3];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testTAD.ponerItems(testItems);

            testItems = new int[4];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testItems[3] = 4;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.insertar(3, 4));
            Assert.AreEqual(4, testTAD.darLongitud());
            Assert.AreEqual(4, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #region Indice Más allá de Longitud
        [TestMethod]
        public void uTestInsertarItemMasAllaDeLongitudConTADVacio()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = null;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.insertar(4, 4));
            Assert.AreEqual(0, testTAD.darLongitud());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestInsertarItemMasAllaDeLongitudEnTADConItems()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[3];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.insertar(4, 4));
            Assert.AreEqual(3, testTAD.darLongitud());
            Assert.AreEqual(3, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #endregion
        #region Extraer Item en Indice
        #region Indice Negativo
        [TestMethod]
        public void uTestExtraerItemConIndiceNegativoConTADVacio()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = null;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.extraer(-1, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testTAD.darLongitud());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemConIndiceNegativoEnTADConItems()
            {  //Poner un metodo mutador para Capacidad en Vectoriales.  bool ponerCapacidad(int prmValor)
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[3];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.extraer(-1, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testTAD.darLongitud());
            Assert.AreEqual(3, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #region Indice Cero
        [TestMethod]
        public void uTestExtraerItemEnIndiceCeroConTADVacio()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = null;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.extraer(0, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testTAD.darLongitud());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemEnIndiceCeroEnTADConItems()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[3] { 1, 2, 3 };
            testTAD.ponerItems(testItems);
            testItems = new int[2] { 2, 3 };
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.extraer(0, ref testItem));
            Assert.AreEqual(1, testItem);
            Assert.AreEqual(2, testTAD.darLongitud());
            Assert.AreEqual(2, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #region Indice Mayor a Cero Menor que Longitud
        [TestMethod]
        public void uTestExtraerItemEnIndiceConTADVacio()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = null;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.extraer(2, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testTAD.darLongitud());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemEnIndiceEnTADConItems()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[3] { 1, 2, 3 };
            testTAD.ponerItems(testItems);
            testItems = new int[2] { 1, 2 };
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.extraer(2, ref testItem));
            Assert.AreEqual(3, testItem);
            Assert.AreEqual(2, testTAD.darLongitud());
            Assert.AreEqual(2, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #region Indice igual a Longitud
        [TestMethod]
        public void uTestExtraerItemEnLongitudConTADVacio()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = null;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.extraer(0, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testTAD.darLongitud());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemEnLongitudEnTADConItems()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[3] { 1, 2, 3 };
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.extraer(3, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testTAD.darLongitud());
            Assert.AreEqual(3, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #region Indice Más allá de Longitud
        [TestMethod]
        public void uTestExtraerItemMasAllaDeLongitudConTADVacio()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = null;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.extraer(4, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testTAD.darLongitud());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestExtraerItemMasAllaDeLongitudEnTADConItems()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[3] { 1, 2, 3 };
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.extraer(4, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testTAD.darLongitud());
            Assert.AreEqual(3, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #endregion
        #region Modificar Item en Indice
        #region Indice Negativo
        [TestMethod]
        public void uTestModificarItemConIndiceNegativoConTADVacio()
            {
            #region Configurar 
            //TODO: Métodos para configurar TAD Vacio, Con Items, Lleno para todos las implementaciones.
            testTAD = new clsListaEnlazada<int>();
            testItems = null;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.modificar(-1, 777));
            Assert.AreEqual(0, testTAD.darLongitud());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemConIndiceNegativoEnTADConItems()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[3];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.modificar(-1, 777));
            Assert.AreEqual(3, testTAD.darLongitud());
            Assert.AreEqual(3, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #region Indice Cero
        [TestMethod]
        public void uTestModificarItemEnIndiceCeroConTADVacio()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = null;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.modificar(0, 777));
            Assert.AreEqual(0, testTAD.darLongitud());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemEnIndiceCeroEnTADConItems()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[3];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testTAD.ponerItems(testItems);
            testItems[0] = 777;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.modificar(0, 777));
            Assert.AreEqual(3, testTAD.darLongitud());
            Assert.AreEqual(3, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #region Indice Mayor a Cero Menor que Longitud
        [TestMethod]
        public void uTestModificarItemEnIndiceConTADVacio()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = null;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.modificar(2, 777));
            Assert.AreEqual(0, testTAD.darLongitud());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemEnIndiceEnTADConItems()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[3];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testTAD.ponerItems(testItems);
            testItems[2] = 777;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.modificar(2, 777));
            Assert.AreEqual(3, testTAD.darLongitud());
            Assert.AreEqual(3, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #region Indice igual a Longitud
        [TestMethod]
        public void uTestModificarItemEnLongitudConTADVacio()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = null;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.modificar(0, 777));
            Assert.AreEqual(0, testTAD.darLongitud());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemEnLongitudEnTADConItems()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[3];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.modificar(3, 777));
            Assert.AreEqual(3, testTAD.darLongitud());
            Assert.AreEqual(3, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #region Indice Más allá de Longitud
        [TestMethod]
        public void uTestModificarItemMasAllaDeLongitudConTADVacio()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = null;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.modificar(4, 777));
            Assert.AreEqual(0, testTAD.darLongitud());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestModificarItemMasAllaDeLongitudEnTADConItems()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[3];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.modificar(4, 777));
            Assert.AreEqual(3, testTAD.darLongitud());
            Assert.AreEqual(3, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #endregion
        #region Recuperar Item en Indice
        #region Indice Negativo
        [TestMethod]
        public void uTestRecuperarItemConIndiceNegativoConTADVacio()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = null;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.recuperar(-1, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testTAD.darLongitud());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemConIndiceNegativoEnTADConItems()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[3];
            testItems[0] = 1;
            testItems[1] = 2;
            testItems[2] = 3;
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.recuperar(-1, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testTAD.darLongitud());
            Assert.AreEqual(3, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #region Indice Cero
        [TestMethod]
        public void uTestRecuperarItemEnIndiceCeroConTADVacio()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = null;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.recuperar(0, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testTAD.darLongitud());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemEnIndiceCeroEnTADConItems()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[3] { 1, 2, 3 };
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.recuperar(0, ref testItem));
            Assert.AreEqual(1, testItem);
            Assert.AreEqual(3, testTAD.darLongitud());
            Assert.AreEqual(3, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #region Indice Mayor a Cero Menor que Longitud
        [TestMethod]
        public void uTestRecuperarItemEnIndiceConTADVacio()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = null;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.recuperar(2, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testTAD.darLongitud());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemEnIndiceEnTADConItems()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[3] { 1, 2, 3 };
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.recuperar(2, ref testItem));
            Assert.AreEqual(3, testItem);
            Assert.AreEqual(3, testTAD.darLongitud());
            Assert.AreEqual(3, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #region Indice igual a Longitud
        [TestMethod]
        public void uTestRecuperarItemEnLongitudConTADVacio()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = null;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.recuperar(0, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testTAD.darLongitud());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemEnLongitudEnTADConItems()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[3] { 1, 2, 3 };
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.recuperar(3, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testTAD.darLongitud());
            Assert.AreEqual(3, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #region Indice Más allá de Longitud
        [TestMethod]
        public void uTestRecuperarItemMasAllaDeLongitudConTADVacio()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = null;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.recuperar(4, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(0, testTAD.darLongitud());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestRecuperarItemMasAllaDeLongitudEnTADConItems()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[3] { 1, 2, 3 };
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.recuperar(4, ref testItem));
            Assert.AreEqual(default(int), testItem);
            Assert.AreEqual(3, testTAD.darLongitud());
            Assert.AreEqual(3, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #endregion
        #region Contiene Item
        [TestMethod]
        public void uTestContieneItemEnTADVacio()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = null;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.contiene(0));
            Assert.AreEqual(0, testTAD.darLongitud());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestContieneItemEnTADConItems()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[3] { 1, 2, 3 };
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.contiene(3));
            Assert.AreEqual(3, testTAD.darLongitud());
            Assert.AreEqual(3, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestNoContieneItemEnTADItems()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[3] { 1, 2, 3 };
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(false, testTAD.contiene(777));
            Assert.AreEqual(3, testTAD.darLongitud());
            Assert.AreEqual(3, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #region Encontrar Item
        [TestMethod]
        public void uTestEncontrarItemEnTADVacio()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = null;
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.encontrar(0) < 0);
            Assert.AreEqual(0, testTAD.darLongitud());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestEncontrarItemEnTADConItems()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[3] { 1, 2, 3 };
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(2, testTAD.encontrar(3));
            Assert.AreEqual(3, testTAD.darLongitud());
            Assert.AreEqual(3, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestEncontrarItemEnTADConItemsVariasOcurrencias()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[3] { 1, 2, 2 };
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(1, testTAD.encontrar(2));
            Assert.AreEqual(3, testTAD.darLongitud());
            Assert.AreEqual(3, testTAD.darItems().Length);
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        [TestMethod]
        public void uTestEncontrarItemEnTADConItemsNingunaOcurrencia()
            {
            #region Configurar
            testTAD = new clsListaEnlazada<int>();
            testItems = new int[3] { 1, 2, 3 };
            testTAD.ponerItems(testItems);
            #endregion
            #region Probar y Comprobar
            Assert.AreEqual(true, testTAD.encontrar(777) < 0);
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
            testTAD = new clsListaEnlazada<int>();
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
            testTAD = new clsListaEnlazada<int>();
            testItems = null;
            #endregion
            #region Comprobar y Comprobar
            Assert.AreEqual(false, testTAD.reversar());
            Assert.AreEqual(0, testTAD.darLongitud());
            CollectionAssert.AreEqual(testItems, testTAD.darItems());
            #endregion
            }
        #endregion
        #endregion
        #endregion
        }
    }
