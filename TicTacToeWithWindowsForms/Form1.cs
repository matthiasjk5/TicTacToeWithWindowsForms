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
            if (button1.Text == "")
            {
                ClickCell(0, 0, button1);
                if (Winner()) { }
                else
                {
                    ComSelected();
                    Winner();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                ClickCell(0, 1, button2);
                if (Winner()) { }
                else
                {
                    ComSelected();
                    Winner();
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                ClickCell(0, 2, button3);
                if (Winner()) { }
                else
                {
                    ComSelected();
                    Winner();
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                ClickCell(1, 0, button4);
                if (Winner()) { }
                else
                {
                    ComSelected();
                    Winner();
                }
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                ClickCell(1, 1, button5);
                if (Winner()) { }
                else
                {
                    ComSelected();
                    Winner();
                }
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                ClickCell(1, 2, button6);
                if (Winner()) { }
                else
                {
                    ComSelected();
                    Winner();
                }
            }
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                ClickCell(2, 0, button7);
                if (Winner()) { }
                else
                {
                    ComSelected();
                    Winner();
                }
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                ClickCell(2, 1, button8);
                if (Winner()) { }
                else
                {
                    ComSelected();
                    Winner();
                }
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                ClickCell(2, 2, button9);
                if (Winner()) { }
                else
                {
                    ComSelected();
                    Winner();
                }
            }
            
        }

        public void displayTurns()
        {
            textBox1.Text = CalculateMark.howManyTurns.ToString();
        }

        public void ClickCell(int row, int column, Button button)
        {
            if (Board.userBoard[row, column] == 1 || Board.comBoard[row, column] == 1)
            {

            }
            else
            {
                button.Text = "X";

                Board.userBoard[row, column] = 1;
                CalculateMark.howManyTurns++;
                displayTurns();
            }
        }

        public void ComSelected()
        {
            Random random = new Random();
            int row = random.Next(0, 3);
            int column = random.Next(0, 3);

            while (Board.comBoard[row, column] == 1 || Board.userBoard[row, column] == 1)
            {
                row = random.Next(0, 3);
                column = random.Next(0, 3);
            }

            CalculateMark.howManyTurns++;

            if (row == 0 && column == 0)
            {
                button1.Text = "O";
                Board.comBoard[row, column] = 1;
            }
            else if (row == 0 && column == 1)
            {
                button2.Text = "O";
                Board.comBoard[row, column] = 1;
            }
            else if (row == 0 && column == 2)
            {
                button3.Text = "O";
                Board.comBoard[row, column] = 1;
            }
            else if (row == 1 && column == 0)
            {
                button4.Text = "O";
                Board.comBoard[row, column] = 1;
            }
            else if (row == 1 && column == 1)
            {
                button5.Text = "O";
                Board.comBoard[row, column] = 1;
            }
            else if (row == 1 && column == 2)
            {
                button6.Text = "O";
                Board.comBoard[row, column] = 1;
            }
            else if (row == 2 && column == 0)
            {
                button7.Text = "O";
                Board.comBoard[row, column] = 1;
            }
            else if (row == 2 && column == 1)
            {
                button8.Text = "O";
                Board.comBoard[row, column] = 1;
            }
            else if (row == 2 && column == 2)
            {
                button9.Text = "O";
                Board.comBoard[row, column] = 1;
            }

            displayTurns();
        }

        public bool Winner()
        {
            if (CalculateMark.WhoWin() == 0 || CalculateMark.WhoWin() == 1)
            {
                string whoWin = CalculateMark.WhoWin() == 0 ? "You" : "Computer";
                DialogResult result = MessageBox.Show(whoWin + " Win! Do you want to play again?", "Game Over", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                }

                else
                {
                    Application.Exit();
                }

                return true;
            }
            else if (CalculateMark.WhoWin() == 2)
            {
                DialogResult result = MessageBox.Show("Draw Game! Do you want to play again?", "Game Over", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                }

                else
                {
                    Application.Exit();
                }

                return true;
            }

            return false;
        }
    }
}
