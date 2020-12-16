using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppw2
{
    [Serializable]
    class PedalRace:Race
    {
        //Attribute
        private double rollerCategory;

        // Property
        public double RollerCategory { get => rollerCategory; set => rollerCategory = value; }

        // Default Constructor
        public PedalRace()
        {
            RollerCategory = 0.0;
        }

        // Parameterised Constructor
        public PedalRace(double pRollerCategory,
            int pID, DateTime pDate, DateTime pStart,
            string pLocation, int pCapacity, double pCost) :
            base(pID, pDate, pStart, pLocation, pCapacity, pCost)
        {
            RollerCategory = pRollerCategory;
        }

        // Overridden ToString()
        public override string ToString()
        {
            return "Roller Category: " + RollerCategory + ", Pedal Race: " + base.ToString();
        }


    }
}
