using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AStar
{
    public class AStarPrime
    {
        public delegate double HeuristicDelegate(IState state, IState goalState);
        private class SearchNode : IEvaluatable
        {
            public IState State { get; set; }
            public double f { get; set; }
            public double g { get; set; }
            public double Value { get { return f; } }
        }

        public bool Search(
            IStateTransition transition,
            IState initialState,
            IState goalState,
            HeuristicDelegate heuristic,
            out Node result, double initialCost=0)
        {
            result = null;
            var fringe = new BinaryHeap<SearchNode>((x, y) => y.Value > x.Value);
            fringe.Insert(new SearchNode()
            {
                f = heuristic(initialState, goalState),
                g = initialCost,
                State = initialState
            });
            var visitedNodes = new Dictionary<IState, SearchNode>();
            visitedNodes.Add(initialState, new SearchNode()
            {
                f = heuristic(initialState,
                goalState),
                g = initialCost,
                State = initialState
            });
            var history = new Dictionary<IState, Node>();
            history.Add(initialState, new Node() { State = initialState });
            while (true)
            {
                if (fringe.Count == 0)
                {
                    return false;
                }
                var node = fringe.Remove();
                if (transition.IsGoal(node.State, goalState))
                {
                    result = history[goalState];
                    return true;
                }
                foreach (var x in transition.Expand(node.State))
                {
                    var state = x.Item1;
                    var _g = x.Item3 + node.g;
                    var _f = _g + heuristic(state, goalState);
                    if (transition.IsGoal(state, goalState))
                        _f = _g;

                    var action = x.Item2;
                    SearchNode visitedNode;
                    Node hnode;
                    if (visitedNodes.TryGetValue(state, out visitedNode))
                    {
                        if (visitedNode.g < _g)
                            hnode = history[state];
                        else
                            continue;
                    }
                    else
                    {
                        visitedNode = new SearchNode();
                        visitedNodes.Add(state, visitedNode);

                        hnode = new Node();
                        history.Add(state, hnode);
                    }
                    visitedNode.f = _f;
                    visitedNode.g = _g;
                    visitedNode.State = state;
                    fringe.Insert(visitedNode);

                    hnode.Previous = history[node.State];
                    hnode.Cost = _g;
                    hnode.PreviousAction = action;
                    hnode.State = state;
                }
            }
        }
    }
}
