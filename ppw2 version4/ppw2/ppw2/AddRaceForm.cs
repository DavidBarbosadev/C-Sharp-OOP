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
    public partial class AddRaceForm : Form
    {
        private Form1 form1;
        public AddRaceForm(Form1 frm)
        {
            InitializeComponent();
            this.form1 = frm;
        }

        private void btnAddMotorRace_Click(object sender, EventArgs e)
        {
            try
            {
                MotorRace race = new MotorRace(Convert.ToBoolean(txtboolsponsor.Text),
                    Convert.ToString(txtSponsorNAme.Text),
                    Convert.ToInt32(txtenginetype.Text),
                    Convert.ToInt32(txtRaceid.Text),
                    Convert.ToDateTime(timeDatePicker.Text),
                    Convert.ToDateTime(txtTime.Text),
                    Convert.ToString(txtLocation.Text),
                    Convert.ToInt32(txtCapacity.Text),
                    Convert.ToDouble(txtCosttt.Text));
                // exeption for ID that Already exists
                if (form1.allRaces.getRacesList().FindIndex(i => i.ID == race.ID) != -1)
                    throw new ArgumentException();
                // Custom exeption
                if (race.Capacity > 50)
                    throw new MaxCapacityExceeded();

                form1.allRaces.AddRace(race);
                form1.refreshRacesTypesList();
                form1.refreshRaceList();
                MessageBox.Show("Motor Race has been added Successfully!", "Success");
                this.Close();
            }
            catch(FormatException)
            {
                MessageBox.Show("Please check the data you have introduced.", "Invalid Input.",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            catch (MaxCapacityExceeded)
            {
                MessageBox.Show("The Max Capacity was reached at 50 people, please remember that races only supports until 50 people.", "Invalid input.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("An entry with this ID already exists.", "Invalid input.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPadelRace_Click(object sender, EventArgs e)
        {
            try
            {
                PedalRace race = new PedalRace(Convert.ToDouble(textBoxRollerCategory.Text),
                Convert.ToInt32(textBoxRaceIdPedal.Text),
                Convert.ToDateTime(dateTimePickerPedalRace.Text),
                Convert.ToDateTime(textBoxTimePedal.Text),
                Convert.ToString(textBoxLocationPedal.Text),
                Convert.ToInt32(textBoxCapacityPedal.Text),
                Convert.ToDouble(textboxCostPedal.Text));

                if (form1.allRaces.getRacesList().FindIndex(i => i.ID == race.ID) != -1)
                    throw new ArgumentException();

                if (race.Capacity > 50)
                    throw new MaxCapacityExceeded();

                form1.allRaces.AddRace(race);
                form1.refreshRacesTypesList();
                form1.refreshRaceList();
                MessageBox.Show("Pedal Race has been added Successfully!", "Success");
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please check the data you have introduced.", "Invalid Input.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (MaxCapacityExceeded)
            {
                MessageBox.Show("The Max Capacity was reached at 50 people, please remember that races only supports until 50 people.", "Invalid input.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("An entry with this ID already exists.", "Invalid input.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbBool_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBool.Text == "False")
            {
                txtboolsponsor.Visible = true;
                txtboolsponsor.Text = "False";
                lblSponsorName.Visible = false;
                txtSponsorNAme.Visible = false;
            }
            else
            {
                txtboolsponsor.Visible = true;
                cbBool.Text = "True";
                txtboolsponsor.Text = "True";
                lblSponsorName.Visible = true;
                txtSponsorNAme.Visible = true;
            }
        }

        private void AddRaceForm_Load(object sender, EventArgs e)
        {
            txtboolsponsor.Visible = false;
        }
    }
}
