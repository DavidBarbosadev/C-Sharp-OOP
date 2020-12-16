using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppw2
{
    [Serializable]
    class MotorRace:Race
    {
        // Attributes
        private bool isSponsored;
        private string sponsorName;
        private int engineType;

        // Properties
        public bool IsSponsored { get => isSponsored; set => isSponsored = value; }
        public string SponsorName { get => sponsorName; set => sponsorName = value; }
        public int EngineType { get => engineType; set => engineType = value; }

        // Default Constructor
        public MotorRace()
        {
            IsSponsored = false;
            SponsorName = "none";
            EngineType = 2;
        }

        // Parameterised Constructor
        public MotorRace(bool pIsSponsored, string pSponsorName, int pEngineType,
            int pID, DateTime pDate, DateTime pStart,
            string pLocation, int pCapacity, double pCost) :
            base(pID, pDate, pStart, pLocation, pCapacity, pCost)
        {
            IsSponsored = pIsSponsored;
            SponsorName = pSponsorName;
            EngineType = pEngineType;
        }

        // Overridden ToString Method
        public override string ToString()
        {
            return " Sponsored: " + IsSponsored + ", Sponsor's Name: " + SponsorName + ", Engine Type: " + EngineType + ", Motor Race: " + base.ToString();
        }
    }
}
