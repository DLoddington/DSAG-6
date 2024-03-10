using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBAssessed.Classes
{
    public class Graph
    {

        private LinkedList<GraphNode> nodes; 

        public Graph() 
        {
            nodes = new LinkedList<GraphNode>();
        }

        public void AddNode(string code) 
        {
            nodes.AddLast(new GraphNode(code)); 
        }

        public void AddEdge(string from, string to)
        {
            GraphNode n1 = GetNodeByCode(from);
            GraphNode n2 = GetNodeByCode(to);
            n1.AddEdge(n2);
        }

        public void RemoveEdge(string from, string to)
        {
            GraphNode n1 = GetNodeByCode(from);
            GraphNode n2 = GetNodeByCode(to);
            n1.RemoveEdge(n2);
        }

        public GraphNode GetNodeByCode(string code)
        {
            foreach (GraphNode n in nodes)
            {
                if (code.ToUpper() == n.Code.ToUpper())
                    return n;
            }
            return null;
        }

        public bool CheckCodeExists(string code)
        {
            foreach (GraphNode n in nodes)
            {
                if (code.ToUpper() == n.Code.ToUpper()) // check for case sensitivity
                    return true;
            }
            return false;
        }


        public void DepthFirstTraverse(string startCode, ref List<string> visited)
        {
            LinkedList<string> adj;
            Stack<string> toVisit = new Stack<string>();
            GraphNode current;

            toVisit.Push(startCode);

            while (toVisit.Count != 0)
            {
                string currentCode = toVisit.Pop();
                if (!visited.Contains(currentCode)) //added this to avoid different routes adding the same airport more than once
                {
                    visited.Add(currentCode);
                }                
                current = GetNodeByCode(currentCode);
                adj = current.GetAdjList();
                foreach (string s in adj)
                {
                    if (!toVisit.Contains(s) && !visited.Contains(s))
                    {
                        toVisit.Push(s);
                    }
                }
            }
        }

        public LinkedList<GraphNode> getList()
        {
            return nodes;
        }

        public int NumOfNodes()
        {
            return nodes.Count();
        }

        public int NumOfEdges() //assuming forward and backward edges to the same nodes are considered separate edges
        {
            int EdgeCount = 0;
            foreach(GraphNode n in nodes)
            {
                EdgeCount = EdgeCount + n.GetAdjList().Count;
            }
            return EdgeCount;
        }
    }
}
