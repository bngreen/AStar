using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AStar;

namespace EightPuzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            movesTB.Text = string.Empty;
            var tboxes = new[] { t0, t1, t2, t3, t4, t5, t6, t7, t8 };
            try
            {
                var grid = tboxes.Select(x => string.IsNullOrWhiteSpace(x.Text) ? (byte)0 : Convert.ToByte(x.Text)).ToArray();
                var init = new State(grid);
                var goal = new State(new byte[9] { 1, 2, 3, 4, 5, 6, 7, 8, 0 });

                AStar.AStar aStar = new AStar.AStar();
                Node result;

                if (aStar.Search(new StateTransition(), init, goal, Heuristics.Manhattan, out result))
                {
                    var actionsList = new List<Action>();
                    var node = result;
                    while (node.Previous != null)
                    {
                        actionsList.Add(node.PreviousAction as Action);
                        node = node.Previous;
                    }
                    actionsList.Reverse();
                    foreach (var x in actionsList)
                        movesTB.AppendText(x.ToString() + "\n");
                }
                else
                    MessageBox.Show("Can't Find Solution");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
