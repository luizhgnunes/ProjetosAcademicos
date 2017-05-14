using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmallRoadWeb.Models.Entities;
using SmallRoadWeb.Controllers;

namespace SmallRoadWeb.Tests.Controllers
{
    /// <summary>
    /// Summary description for NotaFiscalControllerTest
    /// </summary>
    [TestClass]
    public class NotaFiscalControllerTest
    {
        public NotaFiscalControllerTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
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

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void CadastrarNotaFiscal()
        {
            NotaFiscal notaFiscal = new NotaFiscal();
            notaFiscal.Data = DateTime.Now;
            notaFiscal.PrazoEntrega = new DateTime(2017, 5, 30);
            notaFiscal.Destinatario = new Models.Entities.Destinatario();
            notaFiscal.Destinatario.Id = 1;

            NotaFiscalController nfController = new NotaFiscalController();

            Assert.IsTrue(nfController.Cadastrar(notaFiscal));
        }

        [TestMethod]
        public void ObterNotaFiscalPorNumero()
        {
            NotaFiscal notaFiscal = new NotaFiscal();
            notaFiscal.Numero = 1;
            notaFiscal.Data = new DateTime(2017, 5, 14);
            notaFiscal.PrazoEntrega = new DateTime(2017, 5, 30);
            notaFiscal.Destinatario = new Models.Entities.Destinatario();
            notaFiscal.Destinatario.Id = 1;

            NotaFiscalController nfController = new NotaFiscalController();

            NotaFiscal notaFiscalRetornada = nfController.ObterRegistro(notaFiscal.Numero);

            //Assert.Equals(notaFiscal, notaFiscalRetornada);
            Assert.AreEqual(notaFiscalRetornada.Destinatario.Id, 1);
        }

        [TestMethod]
        public void Alterar()
        {
            NotaFiscal notaFiscal = new NotaFiscal();
            notaFiscal.Numero = 1;
            notaFiscal.Data = new DateTime(2017, 5, 14);
            notaFiscal.PrazoEntrega = new DateTime(2017, 5, 29);
            notaFiscal.Destinatario = new Models.Entities.Destinatario();
            notaFiscal.Destinatario.Id = 1;

            NotaFiscalController nfController = new NotaFiscalController();

            Assert.IsTrue(nfController.Alterar(notaFiscal));
        }

        [TestMethod]
        public void Deletar()
        {
            NotaFiscalController nfController = new NotaFiscalController();
            Assert.IsTrue(nfController.Deletar(1));
        }
    }
}
