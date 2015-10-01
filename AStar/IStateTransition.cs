using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AStar
{
    public interface IStateTransition
    {
        IEnumerable<Tuple<IState, IAction, double>> Expand(IState state);
        bool IsGoal(IState state, IState goal);
    }
}
