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
    public partial class AddConnection : Form
    {
        public static AddConnection instance;
        public AddConnection()
        {
            InitializeComponent();
            instance = this;
            CenterToScreen();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(departListBox.SelectedItem == null || arriveListBox.SelectedItem == null)
            {
                DialogResult Result = MessageBox.Show("Ensure you have an arrival and departure airport selected", "Airport selection error", MessageBoxButtons.OK);
                if (Result == DialogResult.OK)
                { return;}
            }

            GraphNode n = Launch.airportGraph.GetNodeByCode(departListBox.SelectedItem.ToString());
            LinkedList<string> adjlist = n.GetAdjList();
            if(adjlist.Contains(arriveListBox.SelectedItem.ToString()))
            {
                DialogResult Result = MessageBox.Show("Route already exists", "Airport selection error", MessageBoxButtons.OK);
                if (Result == DialogResult.OK)
                { return; }
            }
            
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to add a connection between " + departListBox.SelectedItem.ToString() + " and " + arriveListBox.SelectedItem.ToString() + "?", "Add Connection Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Launch.instance.addConnection(departListBox.SelectedItem.ToString(), arriveListBox.SelectedItem.ToString());
            }
            else
                return;
        }

        private void showLists()
        {
            foreach(GraphNode n in Launch.airportGraph.getList())
            {
                departListBox.Items.Add(n.Code);
                arriveListBox.Items.Add(n.Code);
                departListBox.Sorted = true;
                arriveListBox.Sorted = true;
            }
        }

        private void AddConnection_Load(object sender, EventArgs e)
        {
            showLists();
        }
    }
}
