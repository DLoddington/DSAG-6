using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskAAssessed.Forms;
using TaskAAssessed.Classes;

namespace TaskAAssessed
{
    public partial class Launch : Form
    {
        public static Graph graph = new Graph();
        public static Launch instance;
        public Launch()
        {
            InitializeComponent();
            CenterToScreen();
            instance = this;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var newForm = new AddNode();
            newForm.ShowDialog();
        }

        private void addEdgeButton_Click(object sender, EventArgs e)
        {
            var newForm = new AddEdge();
            newForm.ShowDialog();
        }

        private void displayNumNodesButton_Click(object sender, EventArgs e)
        {
            int i = graph.NumOfNodes();
            DialogResult Result = MessageBox.Show("The number of nodes in the graph is " + i + ".", "Node count", MessageBoxButtons.OK);
            if (Result == DialogResult.OK)
            { return; }
        }

        private void displayNumEdgesButton_Click(object sender, EventArgs e)
        {
            int i = graph.NumOfEdges();
            DialogResult Result = MessageBox.Show("The number of edges in the graph is " + i + ".", "Edge count", MessageBoxButtons.OK);
            if (Result == DialogResult.OK)
            { return; }
        }

        internal void addNode(int i)
        {
            graph.AddNode(i);
            DialogResult Result = MessageBox.Show("Success! " + i + " has been added." , "Node add confirmation", MessageBoxButtons.OK);
            if (Result == DialogResult.OK)
            { AddNode.instance.Close(); }
        }

        internal void addEdge(int start, int destin)
        {
            graph.AddEdge(start, destin);
            DialogResult Result = MessageBox.Show("Success! The new edge has been added.", "Connection add confirmation", MessageBoxButtons.OK);
            if (Result == DialogResult.OK)
            { AddEdge.instance.Close(); }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
