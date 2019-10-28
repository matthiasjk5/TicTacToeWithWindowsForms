using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeWithWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CalculateMark.whoseTurn %2 == 0)
            {
                button1.Text = "X";
                button1.Enabled = false;
                CalculateMark.whoseTurn++;
                Board.userBoard[0,0] = 1;
            }
            else
            {
                button1.Text = "0";
                button1.Enabled = false;
                CalculateMark.whoseTurn++;
                Board.comBoard[0, 0] = 0;
            }
        }
    }
}
