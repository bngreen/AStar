using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AStar
{
    class BinaryHeap<T> where T:IEvaluatable
    {
        private List<T> Nodes;
        public int Count { get { return Nodes.Count - 1; } }
        private int Last { get { return Count; } }
        private Tuple<int, int> GetChilds(int parent)
        {
            return new Tuple<int, int>(2 * parent, 2 * parent + 1);
        }
        private int GetParent(int child)
        {
            return (child) / 2;
        }
        public BinaryHeap(Func<T, T, bool> nodeSwitchFunction, int Capacity)
        {
            ShouldSwitchNode = nodeSwitchFunction;
            Nodes = new List<T>(Capacity) { default(T)/*for indexing at 1*/ };
        }
        public BinaryHeap(int Capacity)
            : this((parent, child) => parent.Value < child.Value, Capacity)
        {
        }
        public BinaryHeap()
            : this(30)
        {

        }
        public BinaryHeap(Func<T, T, bool> nodeSwitchFunction)
            : this(nodeSwitchFunction, 30)
        {

        }

        private Func<T, T, bool> ShouldSwitchNode { get; set; }

        public void Insert(T element)
        {
            Nodes.Add(element);
            int index = Last;
            while (index > 1)
            {
                int parent = GetParent(index);
                if (!ShouldSwitchNode(Nodes[parent], Nodes[index]))
                    break;
                SwitchNodes(index, parent);
                index = parent;
            }
        }

        private void SwitchNodes(int node1, int node2)
        {
            var cpy = Nodes[node2];
            Nodes[node2] = Nodes[node1];
            Nodes[node1] = cpy;
        }

        private double GetValue(int index)
        {
            if (index > Count)
                return double.MinValue;
            return Nodes[index].Value;
        }

        public T Remove()
        {
            if (Count == 0)
                return default(T);
            var element = Nodes[1];
            Nodes[1] = Nodes[Last];
            Nodes.RemoveAt(Last);
            int index = 1;
            while (index <= Count)
            {
                var childs = GetChilds(index);
                //int max = GetValue(childs.Item1) > GetValue(childs.Item2) ? childs.Item1 : childs.Item2;
                int val = -1;
                if (childs.Item1 <= Count)
                    val = childs.Item1;
                if (childs.Item2 <= Count)
                {
                    if (val == -1)
                        val = childs.Item2;
                    else
                        val = ShouldSwitchNode(Nodes[childs.Item1], Nodes[childs.Item2]) ? childs.Item2 : childs.Item1;
                }
                if (val != -1 && ShouldSwitchNode(Nodes[index], Nodes[val]))
                {
                    SwitchNodes(index, val);
                    index = val;
                }
                else
                    break;
            }
            return element;
        }
    }
}
