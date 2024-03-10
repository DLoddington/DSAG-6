using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskAAssessed.Classes;
using TaskAAssessed.Forms;

namespace TaskAAssessed.Forms
{
    public partial class AddEdge : Form
    {
        public static AddEdge instance;
        public AddEdge()
        {
            InitializeComponent();
            instance = this;
            CenterToScreen();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (startListBox.SelectedItem == null || destinationListBox.SelectedItem == null)
            {
                DialogResult Result = MessageBox.Show("Ensure you have a starting and destination node selected", "Node selection error", MessageBoxButtons.OK);
                if (Result == DialogResult.OK)
                { return; }
            }

            int start = Int32.Parse(startListBox.SelectedItem.ToString());
            int destin = Int32.Parse(destinationListBox.SelectedItem.ToString());

            GraphNode n = Launch.graph.GetNodeByID(start);
            LinkedList<int> adjlist = n.GetAdjList();
            if (adjlist.Contains(destin))
            {
                DialogResult Result = MessageBox.Show("Edge already exists", "Edge duplication error", MessageBoxButtons.OK);
                if (Result == DialogResult.OK)
                { return; }
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to add a connection between " + startListBox.SelectedItem.ToString() + " and " + destinationListBox.SelectedItem.ToString() + "?", "Add Edge Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Launch.instance.addEdge(start, destin);
            }
            else
                return;
        }

        private void showLists()
        {
            foreach (GraphNode n in Launch.graph.getList())
            {
                startListBox.Items.Add(n.ID);
                destinationListBox.Items.Add(n.ID);
            }
        }

        private void AddEdge_Load(object sender, EventArgs e)
        {
            showLists();
        }
    }
}
