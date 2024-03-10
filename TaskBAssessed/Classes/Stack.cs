using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBAssessed.Classes
{
    class Stack
    {
        private const int maxsize = 100;
        private int top = 0;
        private string[] array = new string[maxsize];

        public void Push(string value) //check isFull in this before proceeding
        {
            if (IsFull() != true) //avoids out of bounds indexing
            {
                array[top++] = value;
            }
            else
            {
                Console.WriteLine("Stack is full, pop some values to continue!");
            }
        }

        public string Pop() //harder to check isEmpty here as this is an int and not a void function, best to do in main
        {
            return array[--top];
        }

        public string Peek()
        {
            return array[top - 1];
        }

        public bool IsEmpty()
        {
            return top == 0;
        }

        public bool IsFull()
        {
            return top == maxsize;
        }

        public int Count()
        {
            return array.Count();
        }

        public bool Contains(string s)
        {
            foreach (string i in array)
            {
                if (i.Equals(s))
                    return true;
            }
            return false;
        }

    }
}
