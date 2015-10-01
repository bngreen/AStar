using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EightPuzzle
{
    public class Action : AStar.IAction
    {
        private Action()
        {

        }
        public string Name { get; private set; }
        public int MoveX { get; private set; }
        public int MoveY { get; private set; }
        public static Action MoveUp { get { return new Action() { MoveY = 1, Name = "Up" }; } }
        public static Action MoveDown { get { return new Action() { MoveY = -1, Name = "Down" }; } }
        public static Action MoveLeft { get { return new Action() { MoveX = 1, Name = "Left" }; } }
        public static Action MoveRight { get { return new Action() { MoveX = -1, Name = "Right" }; } }
        public static IEnumerable<Action> Actions { get { return new Action[4] { MoveUp, MoveDown, MoveLeft, MoveRight }; } }
        public override string ToString()
        {
            return Name;
        }
    }
}
