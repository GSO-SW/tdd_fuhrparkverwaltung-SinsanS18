using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fuhrparkverwaltung;

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
            int verbrauchProHundertKm = 8;
            int streckeInKilometern = 100;
            int tankInhalt = 10;

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
            int verbrauchProHundertKm = 8;
            int streckeInKilometern = 200;
            int tankInhalt = 10;

            Auto a = new Auto(kilometerstand, verbrauchProHundertKm, tankInhalt);
            
            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(210, a.Kilometerstand);
            Assert.AreEqual(0, a.Tankinhalt);



        }
    
    }
}
