using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppw2
{
    public partial class EditRace : Form
    {
        Race race;
        Form1 mainForm;

        public EditRace(Race race, Form1 mainForm)
        {
            InitializeComponent();
            this.race = race;
            this.mainForm = mainForm;
        }

        private void EditRace_load(object sender, EventArgs e)
        {
        
            txtRaceid.Text = race.ID.ToString();

            if (race.GetType() == typeof(Race))
            {

                txtRaceid.Text = race.ID.ToString();
                timeDatePicker.Text = race.Date.ToString();
                txtTime.Text = race.StartTime.ToString();
                txtLocation.Text = race.Location.ToString();
                txtCapacity.Text = race.Capacity.ToString();
                txtCosttt.Text = race.Cost.ToString();
            }


            else if(race.GetType() == typeof(MotorRace))
            {
                MotorRace motorRace = (MotorRace)race;

                txtBoxBoolEdit.Text = motorRace.IsSponsored.ToString();
                txtSponsorNAme.Text = motorRace.SponsorName.ToString();
                txtenginetype.Text = motorRace.EngineType.ToString();
                txtRaceid.Text = motorRace.ID.ToString();
                timeDatePicker.Text = motorRace.Date.ToString();
                txtTime.Text = motorRace.StartTime.ToString();
                txtLocation.Text = motorRace.Location.ToString();
                txtCapacity.Text = motorRace.Capacity.ToString();
                txtCosttt.Text = motorRace.Cost.ToString();
                txtRollerCategoryEdit.Visible = false;
                lblRollerCategoryEdit.Visible = false;



            }
            else if (race.GetType()==typeof(PedalRace))
            {
                PedalRace pedalRace = (PedalRace)race;

                
                txtRollerCategoryEdit.Text = pedalRace.RollerCategory.ToString();
                txtRaceid.Text = pedalRace.ID.ToString();
                timeDatePicker.Text = pedalRace.Date.ToString();
                txtTime.Text = pedalRace.StartTime.ToString();
                txtLocation.Text = pedalRace.Location.ToString();
                txtCapacity.Text = pedalRace.Capacity.ToString();
                txtCosttt.Text = pedalRace.Cost.ToString();
                lblEngineType.Visible = false;
                lblSponsorName.Visible = false;
                lblsponsoredit.Visible = false;
                txtBoxBoolEdit.Visible = false;
                txtSponsorNAme.Visible = false;
                cbBoolean.Visible = false;
                txtenginetype.Visible = false;
                

            }
        }

        private void btnSaveRace_Click(object sender, EventArgs e)
        {
            List<Race> races = mainForm.allRaces.getRacesList();
            int raceIndex = races.FindIndex(i => i.ID == race.ID);

            try
            {
                race.ID = Convert.ToInt32(txtRaceid.Text);

                if (race.GetType() == typeof(Race))
                {
                    races[raceIndex] = race;
                    race.ID = Convert.ToInt32(txtRaceid.Text);
                    race.Date = Convert.ToDateTime(timeDatePicker.Text);
                    race.StartTime = Convert.ToDateTime(txtTime.Text);
                    race.Location = Convert.ToString(txtCapacity.Text);
                    race.Capacity = Convert.ToInt32(txtCapacity.Text);
                    race.Cost = Convert.ToDouble(txtCosttt.Text);
                }

                else if(race.GetType() == typeof(MotorRace))
                {
                    MotorRace motorRace = (MotorRace)race;
                    
                    motorRace.IsSponsored = Convert.ToBoolean(txtBoxBoolEdit.Text);
                    motorRace.SponsorName = Convert.ToString(txtSponsorNAme.Text);
                    motorRace.EngineType = Convert.ToInt32(txtenginetype.Text);
                    motorRace.ID = Convert.ToInt32(txtRaceid.Text);
                    motorRace.Date = Convert.ToDateTime(timeDatePicker.Text);
                    motorRace.StartTime = Convert.ToDateTime(txtTime.Text);
                    motorRace.Location = Convert.ToString(txtLocation.Text);
                    motorRace.Capacity = Convert.ToInt32(txtCapacity.Text);
                    motorRace.Cost = Convert.ToDouble(txtCosttt.Text);

                    races[raceIndex] = motorRace;
                  
                   
                }
                else if (race.GetType() == typeof(PedalRace))
                {
                    PedalRace pedalRace = (PedalRace)race;

                    pedalRace.RollerCategory = Convert.ToDouble(txtRollerCategoryEdit.Text);
                    pedalRace.ID = Convert.ToInt32(txtRaceid.Text);
                    pedalRace.Date = Convert.ToDateTime(timeDatePicker.Text);
                    pedalRace.StartTime = Convert.ToDateTime(txtTime.Text);
                    pedalRace.Location = Convert.ToString(txtLocation.Text);
                    pedalRace.Capacity = Convert.ToInt32(txtCapacity.Text);
                    pedalRace.Cost = Convert.ToDouble(txtCosttt.Text);

                    races[raceIndex] = pedalRace;
                }
                mainForm.allRaces.setRacesList(races);
                mainForm.refreshRaceList();
                MessageBox.Show("Race seccessfully edited.", "Success");

            }
            catch(FormatException)
            {
                //if the user does not introduce correct data then this exeption will pop up.
                MessageBox.Show("Invalid format.", "Error");
            }
        }
       /// <summary>
       /// This comboBox will hide or Show the sponsors fields depending on the user's choice...
       /// </summary>
       
        private void cbBoolean_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBoolean.Text == "False")
            {
                txtBoxBoolEdit.Text = "False";
                lblSponsorName.Visible = false;
                txtSponsorNAme.Visible = false;

            }
            else
            {
                txtBoxBoolEdit.Text = "True";
                lblSponsorName.Visible = true;
                txtSponsorNAme.Visible = true;
            }
        }
    }
}
