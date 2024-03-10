using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAAssessed.Classes
{
    public class Graph
    {
        private LinkedList<GraphNode> nodes;

        public Graph()
        {
            nodes = new LinkedList<GraphNode>();
        }

        public void AddNode(int id)
        {
            nodes.AddLast(new GraphNode(id)); 
        }

        public GraphNode GetNodeByID(int id) 
        {
            foreach (GraphNode n in nodes)
            {
                if (id == n.ID)
                    return n;
            }
            return null;
        }

        public void AddEdge(int from, int to)
        {
            GraphNode n1 = GetNodeByID(from);
            GraphNode n2 = GetNodeByID(to);
            n1.AddEdge(n2);
        }

        public bool IsEmptyGraph()
        {
            return nodes.Count() == 0;
        }

        public int NumOfNodes()
        {
            return nodes.Count();
        }

        public int NumOfEdges()
        {
            int EdgeCount = 0;
            foreach (GraphNode n in nodes)
                EdgeCount = EdgeCount + n.GetAdjList().Count();
            return EdgeCount;
        }

        public LinkedList<GraphNode> getList()
        {
            return nodes;
        }
    }
}
