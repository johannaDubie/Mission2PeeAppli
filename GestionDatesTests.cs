using Microsoft.VisualStudio.TestTools.UnitTesting;
using projetPPE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetPPE.Tests
{
    /// <summary>
    /// Classe de test sur la classe de gestion des dates
    /// </summary>
    [TestClass()]
    public class GestionDatesTests
    {
        [TestMethod()]
        public void getMoisPrecedentTest()
        {
            String mois = GestionDates.getMoisPrecedent();
            Assert.AreEqual("11", mois);
        }

        [TestMethod()]
        public void getMoisPrecedentTest1()
        {
            String mois = GestionDates.getMoisPrecedent(DateTime.Today);
            Assert.AreEqual("11", mois);
        }

        [TestMethod()]
        public void getMoisSuivantTest()
        {
            String mois = GestionDates.getMoisSuivant();
            Assert.AreEqual("01", mois);
        }

        [TestMethod()]
        public void getMoisSuivantTest1()
        {
            String mois = GestionDates.getMoisSuivant(DateTime.Today);
            Assert.AreEqual("01", mois);
        }

        [TestMethod()]
        public void getannee()
        {
            String annee = GestionDates.getAnnee(DateTime.Today);
            Assert.AreEqual("2018", annee);
        }

        [TestMethod()]
        public void entreTest()
        {
            int j1 = 15;
            int j2 = 29;
            Boolean test = GestionDates.entre(j1, j2);
            Assert.AreEqual(true, test);
        }

        [TestMethod()]
        public void entreTest1()
        {
            int j1 = 15;
            int j2 = 29;
            Boolean test = GestionDates.entre(j1, j2, DateTime.Today);
            Assert.AreEqual(true, test);
        }
    }
}