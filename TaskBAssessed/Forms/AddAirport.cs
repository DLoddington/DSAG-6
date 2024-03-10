using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskBAssessed.Forms
{
    public partial class AddAirport : Form
    {
        public static AddAirport instance;

        public AddAirport()
        {
            InitializeComponent();
            instance = this;
            CenterToScreen();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(airportTextBox.Text == "")
            {
                DialogResult Result = MessageBox.Show("Aiport code cannot be blank", "Airport code entry error", MessageBoxButtons.OK);
                if (Result == DialogResult.OK)
                { return; }
            }
            
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to add " + airportTextBox.Text + " to the list of airports? ", "Add Airport Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Launch.instance.addAirport(airportTextBox.Text);
            }
            else
                return;
        }
    }
}
