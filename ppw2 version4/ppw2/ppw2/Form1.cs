using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ppw2
{
    public partial class Form1 : Form
    {
        
        public RaceList allRaces;
        public string savedFileName = "Races.dat";
        //This is the form that the serialization will be done! For this work I used Binary Formatter when Serialization the project
        //done by clicking on the save button
        BinaryFormatter formatter = new BinaryFormatter();
        public Form1()
        {
            InitializeComponent();

            try
            {
                DeserializeRaces();
            }
            catch (SerializationException)
            {
                allRaces = new RaceList();
                MessageBox.Show("Corrupt data file.");
            }
            catch (FileNotFoundException)
            {
                allRaces = new RaceList();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            //set the datasource property to the event list in order to display all the events
            LstboxMainPanel.DataSource = allRaces.getRacesList();
            LstboxMainPanel.Refresh();

            // Dynamically fill the list of Race types as we 
            // can use this to populate comboBox1
            refreshRacesTypesList();
        }
        public void DeserializeRaces()
        {
            FileStream file = new FileStream(savedFileName, FileMode.Open, FileAccess.Read);
            allRaces = (RaceList)formatter.Deserialize(file);
            file.Close();
        }
        // Refresh listBox1 depending on which Race type is selected
        private void ComboBoxRaceSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshRaceList();
        }
        
        /// <summary>
        /// Within the RaceTypes list I am using a Foreach loop so the races show up at the main panel.
        /// </summary>
        public void refreshRacesTypesList()
        {
            List<string> RaceTypes = new List<string>();

            foreach (Race thisRace in allRaces.getRacesList())
            {
                string s = thisRace.GetType().Name;
                if (!RaceTypes.Contains(s))
                {
                    RaceTypes.Add(s);
                }
            }

            // Add the list to ComboBoxRaceSelector
            ComboBoxRaceSelector.DataSource = RaceTypes;
        }

        public void refreshRaceList()
        {
            LstboxMainPanel.DataSource = null;
            LstboxMainPanel.Items.Clear();

            foreach (var i in allRaces.getRacesList())
            {
                if (i.GetType().Name == ComboBoxRaceSelector.SelectedItem.ToString())
                {
                    LstboxMainPanel.Items.Add(i);
                }
            }
        }
        // Method for filling data for proof of concept
        // Not needed when data persistence is added

        private void AddSomeHardCodedData()
        {
            //set up some DateTime objects
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
        }

        private void btnAddRace_Click(object sender, EventArgs e)
        {
            AddRaceForm frm = new AddRaceForm(this);
            frm.ShowDialog();
        }

        //button to close the program 
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// These Try and catch does the error handling for the serialization. Which happens when the save button is pressed
        /// </summary>

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                serializeAndStoreRaces();
                MessageBox.Show("Races saved successfully.", "Success");
            }
            catch (SerializationException)
            {
                MessageBox.Show("Unable to serialize Races object.", "Critical serialization error");
            }
            catch (IOException)
            {
                MessageBox.Show("Unable to write data to file, please try again.", "Critical IO error");
            }
        }
        /// <summary>
        /// Using the Class FileStream  in order to Open and Write inside the Races.dat File. 
        /// </summary>
        public void serializeAndStoreRaces()
        {
            FileStream file = new FileStream(savedFileName, FileMode.Create, FileAccess.Write);
            formatter.Serialize(file, allRaces);
            file.Close();
        }

        private void btnEditRace_Click(object sender, EventArgs e)
        {
            if (LstboxMainPanel.SelectedItem == null)
            {
                MessageBox.Show("Please select a Race first.", "Error");
            }
            else
            {
                EditRace form = new EditRace((Race)LstboxMainPanel.SelectedItem, this);
                form.Show();
            }
        }

  

       
    }
}
