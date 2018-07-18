using System;
using System.Linq;
using Aula5.CorralSnakeYellow.BusinessLayer;
using Aula5.CorralSnakeYellow.DomainModel;
using Aula5.CorralSnakeYellow.Repository.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aula5.CorralSnakeYellow.UnitTesting
{
    // Batteria di test
    [TestClass]
    public class Testing
    {
        // Metodo di test
        [TestMethod]
        public void CreazioneClienteConCognomeVuoto()
        {
            Cliente cliente = Cliente.Factory.Crea();
            cliente.Cognome = "";

            Assert.IsNotNull(cliente);
        }

        // Metodo di test
        [TestMethod]
        public void CreazioneClienteConDataNascitaDefault()
        {
            Cliente cliente = Cliente.Factory.Crea();

            // 01/01/0001
            Assert.AreNotEqual(DateTime.MinValue, cliente.DataNascita);
        }

        [TestMethod]
        public void TestMinimaleSulDatabase()
        {
            IRepo repo = DependencyResolver.Get();

            var x = repo.Clienti.ToList().Count;
            Assert.AreEqual(0, x);
            //Assert.IsTrue(x == 0);
        }
    }
}