using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskBAssessed.Classes;

namespace TaskBAssessed.Forms
{
    public partial class RemoveConnection : Form
    {
        public static RemoveConnection instance;
        public RemoveConnection()
        {
            InitializeComponent();
            instance = this;
            CenterToScreen();
        }

        private void RemoveConnection_Load(object sender, EventArgs e)
        {
            showDeparts();
        }

        private void showDeparts()
        {
            foreach (GraphNode n in Launch.airportGraph.getList())
            {
                if (n.GetAdjList().Count() > 0) //filter out any airport that doesnt have arrival aiports
                {
                    departListBox.Items.Add(n.Code);
                    departListBox.Sorted = true;
                }
            }
        }

        private void showLinked()
        {
            arriveListBox.Items.Clear();

            GraphNode n = Launch.airportGraph.GetNodeByCode(departListBox.SelectedItem.ToString());
            foreach(string s in n.GetAdjList())
            {
                arriveListBox.Items.Add(s);
                arriveListBox.Sorted = true;
            }
        }

        private void selectDeparture_Click(object sender, EventArgs e)
        {
            showLinked();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (departListBox.SelectedItem == null || arriveListBox.SelectedItem == null)
            {
                DialogResult Result = MessageBox.Show("Ensure you have an arrival and departure airport selected", "Airport selection error", MessageBoxButtons.OK);
                if (Result == DialogResult.OK)
                { return; }
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove a connection between " + departListBox.SelectedItem.ToString() + " and " + arriveListBox.SelectedItem.ToString() + "?", "Add Connection Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Launch.instance.removeConnection(departListBox.SelectedItem.ToString(), arriveListBox.SelectedItem.ToString());
            }
            else
                return;
        }
    }
}
