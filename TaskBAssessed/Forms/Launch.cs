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

namespace TaskBAssessed
{
    public partial class Launch : Form
    {
        public static Graph airportGraph = new Graph();
        public static Launch instance;
        public Launch()
        {
            InitializeComponent();
            addDummyData();
            instance = this;
            CenterToScreen();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var newForm = new AddAirport();
            newForm.ShowDialog();
        }

        private void addConnectionButton_Click(object sender, EventArgs e)
        {
            var newForm = new AddConnection();
            newForm.ShowDialog();
        }

        private void removeConnectionButton_Click(object sender, EventArgs e)
        {
            var newForm = new RemoveConnection();
            newForm.ShowDialog();
        }

        private void displayRoutesButton_Click(object sender, EventArgs e)
        {
            var newForm = new Routes();
            newForm.ShowDialog();
        }

        internal void addAirport(string s)
        {
            if (airportGraph.CheckCodeExists(s.ToLower()) == true)
            {
                DialogResult dialogueResult = MessageBox.Show("Airport already exists! You cannot enter a duplicate airport", "Airport duplicate error", MessageBoxButtons.OK);
                if (dialogueResult == DialogResult.OK)
                { return; }
            }
            airportGraph.AddNode(s.ToLower());
            DialogResult Result = MessageBox.Show("Success! " + s.ToLower() + " has been added.", "Airport add confirmation", MessageBoxButtons.OK);
            if (Result == DialogResult.OK)
            { AddAirport.instance.Close(); }
        }

        internal void addConnection(string depart, string arrive)
        {
            airportGraph.AddEdge(depart, arrive);
            DialogResult Result = MessageBox.Show("Success! A connection between " + depart + " and " + arrive + " has been added.", "Connection add confirmation", MessageBoxButtons.OK);
            if (Result == DialogResult.OK)
            { AddConnection.instance.Close(); }
        }

        internal void removeConnection(string depart, string arrive)
        {
            airportGraph.RemoveEdge(depart, arrive);
            DialogResult Result = MessageBox.Show("Success! The connection has been removed.", "Connection remove confirmation", MessageBoxButtons.OK);
            if (Result == DialogResult.OK)
            { RemoveConnection.instance.Close(); }
        }

        private void addDummyData()
        {
            airportGraph.AddNode("bru".ToLower());
            airportGraph.AddNode("mad".ToLower());
            airportGraph.AddNode("lcy".ToLower());
            airportGraph.AddNode("waw".ToLower());
            airportGraph.AddNode("cdg".ToLower());
            airportGraph.AddNode("mxp".ToLower());
            airportGraph.AddNode("ber".ToLower());
            airportGraph.AddNode("lux".ToLower());
            airportGraph.AddNode("ams".ToLower());
            airportGraph.AddNode("lis".ToLower());

            airportGraph.AddEdge("mad".ToLower(), "bru".ToLower());
            airportGraph.AddEdge("ber".ToLower(), "mad".ToLower());
            airportGraph.AddEdge("mad".ToLower(), "lcy".ToLower());
            airportGraph.AddEdge("mad".ToLower(), "cdg".ToLower());
            airportGraph.AddEdge("mxp".ToLower(), "lcy".ToLower());
            airportGraph.AddEdge("mxp".ToLower(), "waw".ToLower());
            airportGraph.AddEdge("mxp".ToLower(), "ber".ToLower());
            airportGraph.AddEdge("waw".ToLower(), "lux".ToLower());
            airportGraph.AddEdge("lux".ToLower(), "ams".ToLower());
            airportGraph.AddEdge("ams".ToLower(), "cdg".ToLower());
            airportGraph.AddEdge("cdg".ToLower(), "lis".ToLower());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
