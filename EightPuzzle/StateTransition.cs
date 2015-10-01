using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EightPuzzle
{
    public class StateTransition : AStar.IStateTransition
    {
        public IEnumerable<Tuple<AStar.IState, AStar.IAction, double>> Expand(AStar.IState state)
        {
            var list = new List<Tuple<AStar.IState, AStar.IAction, double>>();
            var st = state as State;
            if (st != null)
            {
                foreach (var x in Action.Actions)
                {
                    State nst;
                    if (st.PerformAction(x, out nst))
                        list.Add(new Tuple<AStar.IState, AStar.IAction, double>(nst, x, 1));
                }
            }
            return list;
        }

        public bool IsGoal(AStar.IState state, AStar.IState goal)
        {
            if (state.CompareTo(goal) == 0)
                return true;
            return false;
        }
    }
}
