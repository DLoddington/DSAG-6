using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBAssessed.Classes
{
    public class GraphNode
    {
        private string code;
        private LinkedList<string> adjList;

        public GraphNode(string code)
        {
            this.code = code;
            adjList = new LinkedList<string>(); //LinkedList more efficient than List - LinkedList of same type as GraphNode (i.e. int,string etc)
        }

        public string Code
        {
            set { code = value; }
            get { return code; }
        }

        public void AddEdge(GraphNode to)
        {
            adjList.AddLast(to.Code);
        }

        public void RemoveEdge(GraphNode to)
        {
            adjList.Remove(to.Code);
        }

        public LinkedList<string> GetAdjList()
        {
            return adjList;
        }
    }
}
