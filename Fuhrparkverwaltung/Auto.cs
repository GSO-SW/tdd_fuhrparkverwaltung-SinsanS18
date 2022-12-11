using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrparkverwaltung
{
    public class Auto
    {
        private int kilometerstand;
        private int verbrauchProHundertKm;
        private int tankInhalt;


        public int Kilometerstand
        {
            get
            {
                return kilometerstand;
            }
        }

        public int VerbrauchProHundertKm
        {
            get
            {
                return verbrauchProHundertKm;
            }
        }

        public int Tankinhalt
        {
            get
            {
                return tankInhalt;
            }
        }

        public Auto (int kilometerstand)
        {
            this.kilometerstand = kilometerstand;
        }
        
            public Auto (int kilometerstand, int verbrauchPro100Km, int tankInhalt) :this(kilometerstand)
        {
            this.verbrauchProHundertKm = verbrauchPro100Km;
            this.tankInhalt = tankInhalt;

        }

       

      public void Fahren(int streckeInKilometer)
        {
            if (streckeInKilometer >= 0)
            {
                
                kilometerstand = kilometerstand + streckeInKilometer;
                tankInhalt = tankInhalt - ((verbrauchProHundertKm * streckeInKilometer) / 100);
                if (tankInhalt < 0)
                {
                    tankInhalt = 0;
                }
            }
            
        }

       



    }











}
