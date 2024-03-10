using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAAssessed.Classes
{
    public class GraphNode
    {
        private int id; // graph of ints. Change variable depending on type of graph
        private LinkedList<int> adjList;

        public GraphNode(int id)
        {
            this.id = id;
            adjList = new LinkedList<int>(); //LinkedList more efficient than List - LinkedList of same type as GraphNode (i.e. int,string etc)
        }

        public int ID
        {
            set { id = value; }
            get { return id; }
        }

        public void AddEdge(GraphNode to)
        {
            adjList.AddLast(to.ID);
        }

        public LinkedList<int> GetAdjList()
        {
            return adjList;
        }

    }
}
