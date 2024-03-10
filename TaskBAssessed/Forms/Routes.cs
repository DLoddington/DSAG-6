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
using TaskBAssessed.Forms;

namespace TaskBAssessed.Forms
{
    public partial class Routes : Form
    {
        public static Routes instance;
        public Routes()
        {
            InitializeComponent();
            instance = this;
            CenterToScreen();
        }

        private void showLinked()
        {
            arriveListBox.Items.Clear();
            GraphNode n = Launch.airportGraph.GetNodeByCode(departListBox.SelectedItem.ToString());
            foreach (string s in n.GetAdjList())
            {
                arriveListBox.Items.Add(s);
                arriveListBox.Sorted = true;
            }
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

        private void Routes_Load(object sender, EventArgs e)
        {
            showDeparts();
        }

        private void routeTypeSelected(object sender, EventArgs e)
        {
            arriveListBox.Items.Clear();
            if (departListBox.SelectedItem == null)
            {
                DialogResult Result = MessageBox.Show("Ensure you have a departure airport selected", "Airport selection error", MessageBoxButtons.OK);
                if (Result == DialogResult.OK)
                { return; }
            }

            if(dropDownSelection.SelectedItem == null)
            {
                DialogResult Result = MessageBox.Show("Ensure you have a route type selected", "Airport selection error", MessageBoxButtons.OK);
                if (Result == DialogResult.OK)
                { return; }
            }
            else if (dropDownSelection.SelectedItem.ToString() == "Direct only")
            {
                showLinked();
            }
            else
            {
                List<string> availRoutes = new List<string>();
                Launch.airportGraph.DepthFirstTraverse(departListBox.SelectedItem.ToString(), ref availRoutes);
                foreach(string s in availRoutes)
                {
                    if (s != departListBox.SelectedItem.ToString())
                    {
                        arriveListBox.Items.Add(s);
                        arriveListBox.Sorted = true;
                    }
                }
            }
        }
    }
}
