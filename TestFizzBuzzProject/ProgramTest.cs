using Kata001FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestFizzBuzzProject
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para ProgramTest y se pretende que
    ///contenga todas las pruebas unitarias ProgramTest.
    ///</summary>
    [TestClass()]
    public class ProgramTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de la prueba que proporciona
        ///la información y funcionalidad para la ejecución de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        // 
        //Puede utilizar los siguientes atributos adicionales mientras escribe sus pruebas:
        //
        //Use ClassInitialize para ejecutar código antes de ejecutar la primera prueba en la clase 
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup para ejecutar código después de haber ejecutado todas las pruebas en una clase
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize para ejecutar código antes de ejecutar cada prueba
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup para ejecutar código después de que se hayan ejecutado todas las pruebas
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Una prueba de FizzBuzz
        ///</summary>
        [TestMethod()]
        public void FizzBuzzTest_1_1()
        {
            int numero = 1; // TODO: Inicializar en un valor adecuado
            string expected = "1"; // TODO: Inicializar en un valor adecuado
            string actual;
            actual = Kata001FizzBuzz.Program.FizzBuzz(numero);
            Assert.AreEqual(expected, actual,"Entra 1 - Sale 1");
        }

        [TestMethod()]
        public void FizzBuzzTest_2_2()
        {
            int numero = 2; // TODO: Inicializar en un valor adecuado
            string expected = "2"; // TODO: Inicializar en un valor adecuado
            string actual;
            actual = Kata001FizzBuzz.Program.FizzBuzz(numero);
            Assert.AreEqual(expected, actual, "Entra 2 - Sale 2");
        }

        [TestMethod()]
        public void FizzBuzzTest_3_Fizz()
        {
            int numero = 3; // TODO: Inicializar en un valor adecuado
            string expected = "Fizz"; // TODO: Inicializar en un valor adecuado
            string actual;
            actual = Kata001FizzBuzz.Program.FizzBuzz(numero);
            Assert.AreEqual(expected, actual, "Entra 3 - Sale Fizz");
        }

        [TestMethod()]
        public void FizzBuzzTest_5_Buzz()
        {
            int numero = 5; // TODO: Inicializar en un valor adecuado
            string expected = "Buzz"; // TODO: Inicializar en un valor adecuado
            string actual;
            actual = Kata001FizzBuzz.Program.FizzBuzz(numero);
            Assert.AreEqual(expected, actual, "Entra 5 - Sale Buzz");
        }

        [TestMethod()]
        public void FizzBuzzTest_3_5_FizzBuzz()
        {
            int numero = 15; // TODO: Inicializar en un valor adecuado
            string expected = "FizzBuzz"; // TODO: Inicializar en un valor adecuado
            string actual;
            actual = Kata001FizzBuzz.Program.FizzBuzz(numero);
            Assert.AreEqual(expected, actual, "Entra 15 - Sale FizzBuzz");
        }
    }
}
