using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppw2
{
    [Serializable]
    public class RaceList
    {
            //declare private list for events 
            private List<Race> races;

            //creating constructor to hold lists 
            public RaceList()
            {
                races = new List<Race>();
            }

            public void setRacesList(List<Race> races)
            {
                this.races = races;
            }

            public List<Race> getRacesList()
            {
                return races;
            }

            //methods to add event to list
            public void AddRace(Race e)
            {
                // TO DO
                // Add further validation 
                races.Add(e);

            }

            public void RemoveRace(Race e)
            {
                // This functionality could be extended / improved.  
                races.Remove(e);
            }
    }
}
