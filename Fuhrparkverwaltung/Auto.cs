using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrparkverwaltung
{
    public class Auto
    {
        private double kilometerstand;
        private double verbrauchProHundertKm;
        private double tankInhalt;


        public double Kilometerstand
        {
            get
            {
                return kilometerstand;
            }
        }

        public double VerbrauchProHundertKm
        {
            get
            {
                return verbrauchProHundertKm;
            }
        }

        public double Tankinhalt
        {
            get
            {
                return tankInhalt;
            }
        }

        public Auto (double kilometerstand)
        {
            this.kilometerstand = kilometerstand;
        }

        public Auto(double kilometerstand, double verbrauchPro100Km, double tankInhalt) : this(kilometerstand)
        {
            this.verbrauchProHundertKm = verbrauchPro100Km;
            this.tankInhalt = tankInhalt;
        }
        

       

      public void Fahren(double  streckeInKilometer)
        {
            if (streckeInKilometer >= 0)
            {
                double restKM = (tankInhalt / verbrauchProHundertKm) * 100;

                double tankSave = tankInhalt;
                //kilometerstand = kilometerstand + streckeInKilometer;
                tankInhalt = tankInhalt - ((verbrauchProHundertKm * streckeInKilometer) / 100);
                if (tankInhalt >= 0)
                {
                    kilometerstand = kilometerstand + streckeInKilometer;
                }
                else
                {
                    tankInhalt = tankSave;
                }
            }
            
        }

       



    }











}
