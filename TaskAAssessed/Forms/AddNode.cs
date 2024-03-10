using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskAAssessed.Forms
{
    public partial class AddNode : Form
    {
        public static AddNode instance;
        public AddNode()
        {
            InitializeComponent();
            instance = this;
            CenterToScreen();
        }

        public bool testEntryIsInt()
        {
            try
            {
                Int32.Parse(nodeTextBox.Text);
            }
            catch(FormatException e)
            {
                return false;
            }
            return true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(nodeTextBox.Text == "" || nodeTextBox.Text == " ") // check blank or 1 space entry
            {
                DialogResult Result = MessageBox.Show("Nodes cannot be blank, please try again.", "Node blank error", MessageBoxButtons.OK);
                if (Result == DialogResult.OK)
                { return; }
            }
            
            if(testEntryIsInt() == false) //check entry isnt an int and error out
            {
                DialogResult Result = MessageBox.Show("Nodes can only store integer numbers. No symbols, letters or decimal places", "Node entry error", MessageBoxButtons.OK);
                if (Result == DialogResult.OK)
                { return; }
            }

            int node = Int32.Parse(nodeTextBox.Text);
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to add " + nodeTextBox.Text + " as a node?", "Add node confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Launch.instance.addNode(node);
            }
            else
                return;
        }
    }
}
