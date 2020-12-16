using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppw2
{
    [Serializable]
    public class Race
    {
        private int id;
        private DateTime date;
        private DateTime startTime;
        private string location;
        private int capacity;
        private double cost;

        // public properties
        // have set all attributes to read-write access
        public int ID { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public string Location { get => location; set => location = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public double Cost { get => cost; set => cost = value; }

        // default constructor
        //empty constructor, no parameters inside of it...
        public Race()
        {
            ID = 0;
            Date = new DateTime();
            StartTime = new DateTime();
            Location = "";
            Capacity = 0;
            Cost = 0;
        }

        public Race(int pID, DateTime pDate, DateTime pStart,
            string pLocation, int pCapacity, double pCost)
        {
            ID = pID;
            Date = pDate;
            StartTime = pStart;
            Location = pLocation;
            Capacity = pCapacity;
            Cost = pCost;
        }

        public override string ToString()
        {
            // TO DO - Incomplete
            //The ToString method will be later used in the subclasses by using the base.ToString
            return "Race ID: " + ID + ", Date: " + Date + ", Start Time: " + StartTime + ", Location: " + Location + ", Capacity: " + Capacity + ", Cost: " + Cost;
        }
    }
}
