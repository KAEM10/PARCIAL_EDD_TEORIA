using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios.Colecciones.Vectoriales;

namespace uTestColecciones
    {
    [TestClass]
    public class uTestOrdenamiento
        {
        #region Atributos de Prueba
        clsPilaVector<int> atrPilaDatos;
        clsPilaVector<clsPersona> atrPilaObjetos;
        int[] atrVectorDeItemsEsperado;
        string atrMensajeResultado;
        #endregion
        #region Casos de Prueba
        #region Casos de Prueba Ordenamiento
        #region Burbuja Simple
        #region Peor Caso
        #region Con Elementos
        [TestMethod]
        public void testOdrenarBurbujaSimplePeorCasoPilaNormalDeEnterosAscendente()
            {
            #region Inicializar
            //atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            //atrMensajeResultado += "El Orden de la Colección quedó ajustado como Ascendente.\n";
            //atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            //atrMensajeResultado += "-Items              :7.\n";
            //atrMensajeResultado += "-Comparaciones      :21.\n";
            //atrMensajeResultado += "-Intercambios       :21.\n";
            //atrMensajeResultado += "-Inserciones        :0.\n";
            //atrMensajeResultado += "-Llamados Recursivos:0.\n";
            //atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            //atrMensajeResultado += "\n-Dias:\t\t0,000.";
            //atrMensajeResultado += "\n-Horas:\t\t0,000.";
            //atrMensajeResultado += "\n-Minutos:\t0,000.";
            //atrMensajeResultado += "\n-Segundos:";
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(7);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //Assert.AreEqual(true, atrPilaDatos.DarMensajeUltimoMetodo().Contains(atrMensajeResultado));
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimplePeorCasoPilaNormalDeEnterosDescendente()
            {
            #region Inicializar
            //atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            //atrMensajeResultado += "El Orden de la Colección quedó ajustado como Descendente.\n";
            //atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            //atrMensajeResultado += "-Items              :7.\n";
            //atrMensajeResultado += "-Comparaciones      :21.\n";
            //atrMensajeResultado += "-Intercambios       :21.\n";
            //atrMensajeResultado += "-Inserciones        :0.\n";
            //atrMensajeResultado += "-Llamados Recursivos:0.\n";
            //atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            //atrMensajeResultado += "\n-Dias:\t\t0,000.";
            //atrMensajeResultado += "\n-Horas:\t\t0,000.";
            //atrMensajeResultado += "\n-Minutos:\t0,000.";
            //atrMensajeResultado += "\n-Segundos:";
            atrVectorDeItemsEsperado = new int[10] { 7, 6, 5, 4, 3, 2, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            }
        [TestMethod]
        public void testOrdenarBurbujaSimplePeorCasoPilaLlenaDeEnterosAscendente()
            {
            #region Inicializar
            //atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            //atrMensajeResultado += "El Orden de la Colección quedó ajustado como Ascendente.\n";
            //atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            //atrMensajeResultado += "-Items              :10.\n";
            //atrMensajeResultado += "-Comparaciones      :45.\n";
            //atrMensajeResultado += "-Intercambios       :45.\n";
            //atrMensajeResultado += "-Inserciones        :0.\n";
            //atrMensajeResultado += "-Llamados Recursivos:0.\n";
            //atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            //atrMensajeResultado += "\n-Dias:\t\t0,000.";
            //atrMensajeResultado += "\n-Horas:\t\t0,000.";
            //atrMensajeResultado += "\n-Minutos:\t0,000.";
            //atrMensajeResultado += "\n-Segundos:";
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimplePeorCasoPilaLlenaDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(10);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        #endregion
        #endregion
        #endregion
        #region Caso Promedio
        #region Con Elementos
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoPromedioPilaNormalDeEnterosDescendente()
            {
            #region Inicializar
            //atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            //atrMensajeResultado += "El Orden de la Colección quedó ajustado como Descendente.\n";
            //atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            //atrMensajeResultado += "-Items              :7.\n";
            //atrMensajeResultado += "-Comparaciones      :21.\n";
            //atrMensajeResultado += "-Intercambios       :4.\n";
            //atrMensajeResultado += "-Inserciones        :0.\n";
            //atrMensajeResultado += "-Llamados Recursivos:0.\n";
            //atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            //atrMensajeResultado += "\n-Dias:\t\t0,000.";
            //atrMensajeResultado += "\n-Horas:\t\t0,000.";
            //atrMensajeResultado += "\n-Minutos:\t0,000.";
            //atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(-2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(-4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(9);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoPromedioPilaNormalDeEnterosAscendente()
            {
            #region Inicializar
            //atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            //atrMensajeResultado += "El Orden de la Colección quedó ajustado como Ascendente.\n";
            //atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            //atrMensajeResultado += "-Items              :7.\n";
            //atrMensajeResultado += "-Comparaciones      :21.\n";
            //atrMensajeResultado += "-Intercambios       :17.\n";
            //atrMensajeResultado += "-Inserciones        :0.\n";
            //atrMensajeResultado += "-Llamados Recursivos:0.\n";
            //atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            //atrMensajeResultado += "\n-Dias:\t\t0,000.";
            //atrMensajeResultado += "\n-Horas:\t\t0,000.";
            //atrMensajeResultado += "\n-Minutos:\t0,000.";
            //atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { -4, -2, 1, 3, 5, 7, 9, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(-2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(-4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(9);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoPromedioPilaLlenaDeEnterosDescendente()
            {
            #region Inicializar
            //atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            //atrMensajeResultado += "El Orden de la Colección quedó ajustado como Descendente.\n";
            //atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            //atrMensajeResultado += "-Items              :10.\n";
            //atrMensajeResultado += "-Comparaciones      :45.\n";
            //atrMensajeResultado += "-Intercambios       :25.\n";
            //atrMensajeResultado += "-Inserciones        :0.\n";
            //atrMensajeResultado += "-Llamados Recursivos:0.\n";
            //atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            //atrMensajeResultado += "\n-Dias:\t\t0,000.";
            //atrMensajeResultado += "\n-Horas:\t\t0,000.";
            //atrMensajeResultado += "\n-Minutos:\t0,000.";
            //atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, -6, -8, -10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(-2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(-4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(-6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(-8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(-10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoPromedioPilaLlenaDeEnterosAscendente()
            {
            #region Inicializar
           atrVectorDeItemsEsperado = new int[10] { -10, -8, -6, -4, -2, 1, 3, 5, 7, 9 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(-2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(-4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(-6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(-8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(-10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            //Assert.AreEqual(true, atrPilaDatos.DarMensajeUltimoMetodo().Contains(atrMensajeResultado));
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        #endregion
        #endregion
        #region Mejor Caso 
        #region Con Elementos
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaNormalDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            //atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            //atrMensajeResultado += "El Orden de la Colección quedó ajustado como Descendente.\n";
            //atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            //atrMensajeResultado += "-Items              :7.\n";
            //atrMensajeResultado += "-Comparaciones      :21.\n";
            //atrMensajeResultado += "-Intercambios       :0.\n";
            //atrMensajeResultado += "-Inserciones        :0.\n";
            //atrMensajeResultado += "-Llamados Recursivos:0.\n";
            //atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            //atrMensajeResultado += "\n-Dias:\t\t0,000.";
            //atrMensajeResultado += "\n-Horas:\t\t0,000.";
            //atrMensajeResultado += "\n-Minutos:\t0,000.";
            //atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaNormalDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            //atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            //atrMensajeResultado += "El Orden de la Colección quedó ajustado como Ascendente.\n";
            //atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            //atrMensajeResultado += "-Items              :7.\n";
            //atrMensajeResultado += "-Comparaciones      :21.\n";
            //atrMensajeResultado += "-Intercambios       :0.\n";
            //atrMensajeResultado += "-Inserciones        :0.\n";
            //atrMensajeResultado += "-Llamados Recursivos:0.\n";
            //atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            //atrMensajeResultado += "\n-Dias:\t\t0,000.";
            //atrMensajeResultado += "\n-Horas:\t\t0,000.";
            //atrMensajeResultado += "\n-Minutos:\t0,000.";
            //atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { 4, 5, 6, 7, 8, 9, 10, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(10);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(4);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaLlenaDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            //atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            //atrMensajeResultado += "El Orden de la Colección quedó ajustado como Descendente.\n";
            //atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            //atrMensajeResultado += "-Items              :10.\n";
            //atrMensajeResultado += "-Comparaciones      :45.\n";
            //atrMensajeResultado += "-Intercambios       :0.\n";
            //atrMensajeResultado += "-Inserciones        :0.\n";
            //atrMensajeResultado += "-Llamados Recursivos:0.\n";
            //atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            //atrMensajeResultado += "\n-Dias:\t\t0,000.";
            //atrMensajeResultado += "\n-Horas:\t\t0,000.";
            //atrMensajeResultado += "\n-Minutos:\t0,000.";
            //atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleMejorCasoPilaLlenaDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            //atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            //atrMensajeResultado += "El Orden de la Colección quedó ajustado como Ascendente.\n";
            //atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            //atrMensajeResultado += "-Items              :10.\n";
            //atrMensajeResultado += "-Comparaciones      :45.\n";
            //atrMensajeResultado += "-Intercambios       :0.\n";
            //atrMensajeResultado += "-Inserciones        :0.\n";
            //atrMensajeResultado += "-Llamados Recursivos:0.\n";
            //atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            //atrMensajeResultado += "\n-Dias:\t\t0,000.";
            //atrMensajeResultado += "\n-Horas:\t\t0,000.";
            //atrMensajeResultado += "\n-Minutos:\t0,000.";
            //atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(10);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        #endregion
        #endregion
        #region Caso Constante
        #region Con Elementos
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaNormalDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            //atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            //atrMensajeResultado += "El Orden de la Colección quedó ajustado como Descendente.\n";
            //atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            //atrMensajeResultado += "-Items              :7.\n";
            //atrMensajeResultado += "-Comparaciones      :21.\n";
            //atrMensajeResultado += "-Intercambios       :0.\n";
            //atrMensajeResultado += "-Inserciones        :0.\n";
            //atrMensajeResultado += "-Llamados Recursivos:0.\n";
            //atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            //atrMensajeResultado += "\n-Dias:\t\t0,000.";
            //atrMensajeResultado += "\n-Horas:\t\t0,000.";
            //atrMensajeResultado += "\n-Minutos:\t0,000.";
            //atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaNormalDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            //atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            //atrMensajeResultado += "El Orden de la Colección quedó ajustado como Ascendente.\n";
            //atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            //atrMensajeResultado += "-Items              :7.\n";
            //atrMensajeResultado += "-Comparaciones      :21.\n";
            //atrMensajeResultado += "-Intercambios       :0.\n";
            //atrMensajeResultado += "-Inserciones        :0.\n";
            //atrMensajeResultado += "-Llamados Recursivos:0.\n";
            //atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            //atrMensajeResultado += "\n-Dias:\t\t0,000.";
            //atrMensajeResultado += "\n-Horas:\t\t0,000.";
            //atrMensajeResultado += "\n-Minutos:\t0,000.";
            //atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaLlenaDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            //atrMensajeResultado = "El método <Ordenamiento por BurbujaSimple> de <Pila Vector> ha finalizado correctamente reportando lo siguiente:\n";
            //atrMensajeResultado += "El Orden de la Colección quedó ajustado como Descendente.\n";
            //atrMensajeResultado += "El Método de Ordenamiento BurbujaSimple arrojó los siguientes datos:\n";
            //atrMensajeResultado += "-Items              :10.\n";
            //atrMensajeResultado += "-Comparaciones      :45.\n";
            //atrMensajeResultado += "-Intercambios       :0.\n";
            //atrMensajeResultado += "-Inserciones        :0.\n";
            //atrMensajeResultado += "-Llamados Recursivos:0.\n";
            //atrMensajeResultado += "El tiempo de Ejecución del Método fue de:";
            //atrMensajeResultado += "\n-Dias:\t\t0,000.";
            //atrMensajeResultado += "\n-Horas:\t\t0,000.";
            //atrMensajeResultado += "\n-Minutos:\t0,000.";
            //atrMensajeResultado += "\n-Segundos:";

            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaSimpleCasoConstantePilaLlenaDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaSimple(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        #endregion
        #endregion
        #endregion
        #region Burbuja Mejorado
        #region Peor Caso
        #region Con Elementos
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPeorCasoPilaNormalDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(7);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPeorCasoPilaNormalDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 7, 6, 5, 4, 3, 2, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPeorCasoPilaLlenaDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoPeorCasoPilaLlenaDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(10);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        #endregion
        #endregion
        #region Caso Promedio
        #region Con Elementos
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoPromedioPilaNormalDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(-2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(-4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(9);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoPromedioPilaNormalDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { -4, -2, 1, 3, 5, 7, 9, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(-2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(-4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(9);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoPromedioPilaLlenaDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, -6, -8, -10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(-2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(-4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(-6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(-8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(-10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoPromedioPilaLlenaDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { -10, -8, -6, -4, -2, 1, 3, 5, 7, 9 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(-2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(-4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(-6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(-8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(-10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        #endregion
        #endregion
        #region Mejor Caso 
        #region Con Elementos
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaNormalDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaNormalDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 4, 5, 6, 7, 8, 9, 10, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(10);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(4);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaLlenaDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoMejorCasoPilaLlenaDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(10);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        #endregion
        #endregion
        #region Caso Constante
        #region Con Elementos

        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoConstantePilaNormalDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoConstantePilaNormalDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoConstantePilaLlenaDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaMejoradoCasoConstantePilaLlenaDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaMejorado(false);
            #endregion
            #region Comprobar
           CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        #endregion
        #endregion
        #endregion
        #region Burbuja BiDireccional
        #region Peor Caso
        #region Con Elementos
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalPeorCasoPilaNormalDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(7);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalPeorCasoPilaNormalDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 7, 6, 5, 4, 3, 2, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalPeorCasoPilaLlenaDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalPeorCasoPilaLlenaDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(10);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar
CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        #endregion
        #endregion
        #region Caso Promedio
        #region Con Elementos
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoPromedioPilaNormalDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(-2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(-4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(9);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoPromedioPilaNormalDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { -4, -2, 1, 3, 5, 7, 9, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(-2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(-4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(9);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoPromedioPilaLlenaDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, -6, -8, -10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(-2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(-4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(-6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(-8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(-10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoPromedioPilaLlenaDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { -10, -8, -6, -4, -2, 1, 3, 5, 7, 9 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(-2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(-4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(-6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(-8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(-10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        #endregion
        #endregion
        #region Mejor Caso 
        #region Con Elementos
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalMejorCasoPilaNormalDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalMejorCasoPilaNormalDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 4, 5, 6, 7, 8, 9, 10, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(10);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(4);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar
CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalMejorCasoPilaLlenaDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalMejorCasoPilaLlenaDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(10);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar
CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        #endregion
        #endregion
        #region Caso Constante
        #region Con Elementos
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoConstantePilaNormalDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar
CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoConstantePilaNormalDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar
CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoConstantePilaLlenaDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarBurbujaBiDireccionalCasoConstantePilaLlenaDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarBurbujaBiDireccional(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        #endregion
        #endregion
        #endregion
        #region Inserción
        #region Peor Caso
        #region Con Elementos
        [TestMethod]
        public void testOrdenarInsercionPeorCasoPilaNormalDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(7);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionPeorCasoPilaNormalDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 7, 6, 5, 4, 3, 2, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionPeorCasoPilaLlenaDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionPeorCasoPilaLlenaDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(10);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(true);
            #endregion
            #region Comprobar
                        CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        #endregion
        #endregion
        #region Caso Promedio
        #region Con Elementos
        [TestMethod]
        public void testOrdenarInsercionCasoPromedioPilaNormalDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(-2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(-4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(9);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionCasoPromedioPilaNormalDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { -4, -2, 1, 3, 5, 7, 9, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(-2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(-4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(9);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionCasoPromedioPilaLlenaDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, -6, -8, -10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(-2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(-4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(-6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(-8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(-10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionCasoPromedioPilaLlenaDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { -10, -8, -6, -4, -2, 1, 3, 5, 7, 9 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(-2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(-4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(-6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(-8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(-10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        #endregion
        #endregion
        #region Mejor Caso 
        #region Con Elementos
        [TestMethod]
        public void testOrdenarInsercionMejorCasoPilaNormalDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionMejorCasoPilaNormalDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 4, 5, 6, 7, 8, 9, 10, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(10);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(4);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionMejorCasoPilaLlenaDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionMejorCasoPilaLlenaDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(10);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        #endregion
        #endregion
        #region Caso Constante
        #region Con Elementos
        [TestMethod]
        public void testOrdenarInsercionCasoConstantePilaNormalDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionCasoConstantePilaNormalDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionCasoConstantePilaLlenaDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarInsercionCasoConstantePilaLlenaDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarInsercion(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        #endregion
        #endregion
        #endregion
        #region Selección
        #region Peor Caso
        #region Con Elementos
        [TestMethod]
        public void testOrdenarSeleccionPeorCasoPilaNormalDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(7);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionPeorCasoPilaNormalDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 7, 6, 5, 4, 3, 2, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionPeorCasoPilaLlenaDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionPeorCasoPilaLlenaDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(10);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        #endregion
        #endregion
        #region Caso Promedio
        #region Con Elementos
        [TestMethod]
        public void testOrdenarSeleccionCasoPromedioPilaNormalDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(-2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(-4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(9);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionCasoPromedioPilaNormalDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { -4, -2, 1, 3, 5, 7, 9, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(-2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(-4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(9);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionCasoPromedioPilaLlenaDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, -6, -8, -10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(-2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(-4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(-6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(-8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(-10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionCasoPromedioPilaLlenaDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { -10, -8, -6, -4, -2, 1, 3, 5, 7, 9 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(-2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(-4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(-6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(-8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(-10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        #endregion
        #endregion
        #region Mejor Caso 
        #region Con Elementos
        [TestMethod]
        public void testOrdenarSeleccionMejorCasoPilaNormalDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionMejorCasoPilaNormalDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 4, 5, 6, 7, 8, 9, 10, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(10);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(4);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionMejorCasoPilaLlenaDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionMejorCasoPilaLlenaDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(10);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        #endregion
        #endregion
        #region Caso Constante
        #region Con Elementos
        [TestMethod]
        public void testOrdenarSeleccionCasoConstantePilaNormalDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionCasoConstantePilaNormalDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionCasoConstantePilaLlenaDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarSeleccionCasoConstantePilaLlenaDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarSeleccion(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        #endregion
        #endregion
        #endregion
        #region QuickSort
        #region Peor Caso
        #region Con Elementos
        [TestMethod]
        public void testOrdenarQuickSortPeorCasoPilaNormalDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(7);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortPeorCasoPilaNormalDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 7, 6, 5, 4, 3, 2, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortPeorCasoPilaLlenaDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortPeorCasoPilaLlenaDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(10);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        #endregion
        #endregion
        #region Caso Promedio
        #region Con Elementos
        [TestMethod]
        public void testOrdenarQuickSortCasoPromedioPilaNormalDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(-2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(-4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(9);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortCasoPromedioPilaNormalDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { -4, -2, 1, 3, 5, 7, 9, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(-2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(-4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(9);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortCasoPromedioPilaLlenaDeEnterosDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 9, 7, 5, 3, 1, -2, -4, -6, -8, -10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(-2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(-4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(-6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(-8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(-10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortCasoPromedioPilaLlenaDeEnterosAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { -10, -8, -6, -4, -2, 1, 3, 5, 7, 9 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(-2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(-4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(-6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(-8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(-10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        #endregion
        #endregion
        #region Mejor Caso 
        #region Con Elementos
        [TestMethod]
        public void testOrdenarQuickSortMejorCasoPilaNormalDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortMejorCasoPilaNormalDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 4, 5, 6, 7, 8, 9, 10, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(10);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(4);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortMejorCasoPilaLlenaDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(10);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortMejorCasoPilaLlenaDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(10);
            atrPilaDatos.apilar(9);
            atrPilaDatos.apilar(8);
            atrPilaDatos.apilar(7);
            atrPilaDatos.apilar(6);
            atrPilaDatos.apilar(5);
            atrPilaDatos.apilar(4);
            atrPilaDatos.apilar(3);
            atrPilaDatos.apilar(2);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        #endregion
        #endregion
        #region Caso Constante
        #region Con Elementos
        [TestMethod]
        public void testOrdenarQuickSortCasoConstantePilaNormalDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortCasoConstantePilaNormalDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortCasoConstantePilaLlenaDeEnterosFuerzaBrutaDescendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(true);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        [TestMethod]
        public void testOrdenarQuickSortCasoConstantePilaLlenaDeEnterosFuerzaBrutaAscendente()
            {
            #region Inicializar
            atrVectorDeItemsEsperado = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            atrPilaDatos = new clsPilaVector<int>(10);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            atrPilaDatos.apilar(1);
            #endregion
            #region Probar
            atrPilaDatos.OrdenarQuickSort(false);
            #endregion
            #region Comprobar
            CollectionAssert.AreEqual(atrVectorDeItemsEsperado, atrPilaDatos.darItems());
            #endregion
            }
        #endregion
        #endregion
        #endregion
        #endregion
        #endregion
        }
    }
