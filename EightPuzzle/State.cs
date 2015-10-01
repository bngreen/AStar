using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EightPuzzle
{
    public class State : AStar.IState
    {
        public UInt64 GridData { get; private set; }
        private State()
        {
        }
        public State(byte[] state)
        {
            for (int i = 0; i < 9; i++)
            {
                int x = i % 3;
                int y = i / 3;
                this[x, y] = state[i];
            }
        }
        public byte this[int x, int y]
        {
            get
            {
                int i = (y * 3 + x) * 4;
                return (byte)((GridData >> i) & 0x0f);
            }
            set
            {
                int i = (y * 3 + x) * 4;
                GridData &= ~(((UInt64)(0x0f)) << i);
                GridData |= ((UInt64)(value & 0x0f)) << i;
            }
        }

        public bool GetNumberPosition(byte number, out int x, out int y)
        {
            x = y = -1;
            for (int i = 0; i < 3; i++)
            {
                for (int o = 0; o < 3; o++)
                {
                    if (this[i, o] == number)
                    {
                        x = i;
                        y = o;
                        return true;
                    }
                }
            }
            return false;
        }

        public bool GetZeroPosition(out int x, out int y)
        {
            return GetNumberPosition(0, out x, out y);
        }

        private bool IsOnBounds(int x, int y)
        {
            if (x < 0 || x >= 3)
                return false;
            if (y < 0 || y >= 3)
                return false;
            return true;
        }

        public bool PerformAction(Action action, out State state)
        {
            state = null;
            int x, y;
            if (!GetZeroPosition(out x, out y))
                return false;
            var nx = x + action.MoveX;
            var ny = y + action.MoveY;
            if (!IsOnBounds(nx, ny))
                return false;
            state = new State();
            state.GridData = GridData;
            state[x, y] = state[nx, ny];
            state[nx, ny] = 0;
            return true;
        }

        public int CompareTo(AStar.IState other)
        {
            var state = other as State;
            if (state == null)
                return -1;
            return (int)(state.GridData - GridData);
        }
        public override int GetHashCode()
        {
            int hash = (int)(GridData & 0xffffffff);
            hash *= 251;
            hash += (int)(GridData >> 32);
            return hash;
        }
        public override bool Equals(object obj)
        {
            var state = obj as State;
            if (state == null)
                return false;
            if (GridData == state.GridData)
                return true;
            return false;
        }
        public override string ToString()
        {
            var str = string.Empty;
            for (int i = 0; i < 3; i++)
                for (int o = 0; o < 3; o++)
                    str += String.Format("{0} ", this[o, i]);
            return str.TrimEnd(' ');
        }
    }
}
