using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AStar
{
    public class Node
    {
        public Node Previous { get; set; }
        public IAction PreviousAction { get; set; }
        public double Cost { get; set; }
        public IState State { get; set; }
    }
}
