using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ppw2Test;
//using ppw2;
/// <summary>
/// I can't put using ppw2 and that is why the test is getting erros...
/// </summary>
namespace ppw2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSerialization()
        {
            Form1 form = new Form1();
            RaceList races = new RaceList();

            DateTime startDate1 = new DateTime(2017, 12, 21);
            DateTime startDate2 = new DateTime(2011, 10, 19);
            DateTime startDate3 = new DateTime(2017, 12, 22);
            DateTime startDate4 = new DateTime(2019, 09, 23);

            //set up some DateTime objects
            DateTime time1 = new DateTime(2019, 12, 12);
            time1.Date.Add(new TimeSpan(10, 20, 00));

            DateTime time2 = new DateTime(2020, 10, 19);
            time2.Date.Add(new TimeSpan(12, 00, 00));

            DateTime time3 = new DateTime(2019, 12, 22);
            time3.Date.Add(new TimeSpan(12, 00, 00));

            DateTime time4 = new DateTime(2020, 09, 23);
            time4.Date.Add(new TimeSpan(18, 00, 00));

            // objects
            PedalRace race1 = new PedalRace(12, 1, startDate1, time1, "Stadium of Light", 15, 25.00);
            PedalRace race2 = new PedalRace(18, 2, startDate2, time2, "Durham Services", 25, 30.00);
            MotorRace race3 = new MotorRace(true, "University of Sunderland", 2, 3, startDate3, time3, "St Peters", 25, 5.00);
            MotorRace race4 = new MotorRace(true, "SAFC", 2, 4, startDate4, time4, "The Bridges", 25, 5.00);

            //Add races to list.
            allRaces.AddRace(race1);
            allRaces.AddRace(race2);
            allRaces.AddRace(race3);
            allRaces.AddRace(race4);

            form.allRaces = races;

            try
            {
                form.serializeAndStoreParcels();
            }
            catch
            {
                Assert.Fail("Failed to serialize and store Races.");
            }
        }

        [TestMethod]
        public void TestDeserialization()
        {
            Form1 form = new Form1();
            Assert.AreEqual(4, (form.allRaces.getRacesList()).Count, "Deserialized Races must be exactly 4.");
        }
    }
}
