using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EightPuzzle
{
    public class Heuristics
    {
        public static AStar.AStar.HeuristicDelegate Manhattan
        {
            get
            {
                return (state, goal) =>
                {
                    double cost = 0;
                    var st = state as State;
                    var gst = goal as State;
                    for (byte i = 0; i < 9; i++)
                    {
                        int sx, sy, gx, gy;
                        st.GetNumberPosition(i, out sx, out sy);
                        gst.GetNumberPosition(i, out gx, out gy);
                        cost += Math.Abs(gx - sx) + Math.Abs(gy - sy);
                    }
                    return cost;
                };
            }
        }
        public static AStar.AStar.HeuristicDelegate Hamming
        {
            get
            {
                return (state, goal) =>
                {
                    double cost = 0;
                    var st = state as State;
                    var gst = goal as State;
                    for (int i = 0; i < 3; i++)
                        for (int o = 0; o < 3; o++)
                            if (st[i, o] != gst[i, o])
                                cost += 1;
                    return cost;
                };
            }
        }
        public static AStar.AStar.HeuristicDelegate BestFirst
        {
            get { return (a, b) => 0; }
        }
    }
}
