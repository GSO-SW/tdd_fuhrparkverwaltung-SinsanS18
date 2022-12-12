using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fuhrparkverwaltung;
using System.Security.Cryptography.X509Certificates;
using NuGet.Frameworks;

namespace FuhrparkverwaltungTests
{
    [TestClass]
    public class AutoTests
    {
        [TestMethod]
        public void Fahren_SteigertKilometerstand()
        {
            //Arrange
            int kilometerstand = 0;
            Auto a = new Auto(kilometerstand);
            int streckeInKilometern = 50;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(50, a.Kilometerstand);
        }


        [TestMethod]

        public void Unveraendert_Negativ()
        {
            //Arrange
            int kilometerstand = 10;
            Auto a = new Auto(kilometerstand);
            int streckeInKilometern = -1;


            //Act
            a.Fahren(streckeInKilometern);

            //Assert

            Assert.AreEqual(10, a.Kilometerstand);

        }


        [TestMethod]
        
        public void Fahren_WenigerTank()
        {
            //Arrange

            int kilometerstand = 10;                                    
            double verbrauchProHundertKm = 8;
            int streckeInKilometern = 100;
            double tankInhalt = 10;

            Auto a = new Auto(kilometerstand, verbrauchProHundertKm, tankInhalt );

            //Act

            a.Fahren(streckeInKilometern);
            

            //Assert
            Assert.AreEqual(110, a.Kilometerstand);
            Assert.AreEqual(2, a.Tankinhalt);
        }

        [TestMethod]
        public void Fahren_WenigerTankNichtNegativ()
        {
            //Arrange

            int kilometerstand = 10;
            double verbrauchProHundertKm = 8;
            int streckeInKilometern = 200;
            double tankInhalt = 10;

            Auto a = new Auto(kilometerstand, verbrauchProHundertKm, tankInhalt);
            
            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(210, a.Kilometerstand);
            Assert.AreEqual(0, a.Tankinhalt);

        }

        [TestMethod]

        //Aufg 5 nicht vollständig

        public void Realistische_Fahrt()
        {

            //Arrange
            double kilometerstand = 10;
            double verbrauchProHundertKm = 8;
            double streckeInKilometern = 200;
            double tankInhalt = 10;

            Auto a = new Auto(kilometerstand, verbrauchProHundertKm, tankInhalt);



            //Act
            a.Fahren(streckeInKilometern);

            //Assert

            Assert.AreEqual(160, a.Kilometerstand);
            Assert.AreEqual(0, a.Tankinhalt);

        }

    }
}
