using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeWithWindowsForms
{
    class CalculateMark
    {
        public static int howManyTurns = 0; // User: 0, Computer: 1

        // initialize array
        public static void initBoard()
        {
            Board.comBoard = new int[3, 3];
            
        }

        //public static void Winner()
        //{
        //    if (WhoWin() == 0 || WhoWin() == 1)
        //    {
        //        string who = CalculateMark.WhoWin() == 0 ? "You" : "Computer";
        //        MessageBox.Show(who + " Win! Do you want to play again?", "Game Over", MessageBoxButtons.YesNo);
        //    }
        //}

        // return 0: user wins. return 1: computer wins
        public static int WhoWin()
        {
            // user wins - retun 0
            if (Board.userBoard[0, 0] == 1 && Board.userBoard[0, 1] == 1 && Board.userBoard[0, 2] == 1)
            {
                return 0;
            }
            else if (Board.userBoard[1, 0] == 1 && Board.userBoard[1, 1] == 1 && Board.userBoard[1, 2] == 1)
            {
                return 0;
            }
            else if (Board.userBoard[2, 0] == 1 && Board.userBoard[2, 1] == 1 && Board.userBoard[2, 2] == 1)
            {
                return 0;
            }
            else if (Board.userBoard[0, 0] == 1 && Board.userBoard[1, 0] == 1 && Board.userBoard[2, 0] == 1)
            {
                return 0;
            }
            else if (Board.userBoard[0, 1] == 1 && Board.userBoard[1, 1] == 1 && Board.userBoard[2, 1] == 1)
            {
                return 0;
            }
            else if (Board.userBoard[0, 2] == 1 && Board.userBoard[1, 2] == 1 && Board.userBoard[2, 2] == 1)
            {
                return 0;
            }
            else if (Board.userBoard[0, 0] == 1 && Board.userBoard[1, 1] == 1 && Board.userBoard[2, 2] == 1)
            {
                return 0;
            }
            else if (Board.userBoard[0, 2] == 1 && Board.userBoard[1, 1] == 1 && Board.userBoard[2, 0] == 1)
            {
                return 0;
            }

            // computer wins - return 1
            if (Board.comBoard[0, 0] == 1 && Board.comBoard[0, 1] == 1 && Board.comBoard[0, 2] == 1)
            {
                return 1;
            }
            else if (Board.comBoard[1, 0] == 1 && Board.comBoard[1, 1] == 1 && Board.comBoard[1, 2] == 1)
            {
                return 1;
            }
            else if (Board.comBoard[2, 0] == 1 && Board.comBoard[2, 1] == 1 && Board.comBoard[2, 2] == 1)
            {
                return 1;
            }
            else if (Board.comBoard[0, 0] == 1 && Board.comBoard[1, 0] == 1 && Board.comBoard[2, 0] == 1)
            {
                return 1;
            }
            else if (Board.comBoard[0, 1] == 1 && Board.comBoard[1, 1] == 1 && Board.comBoard[2, 1] == 1)
            {
                return 1;
            }
            else if (Board.comBoard[0, 2] == 1 && Board.comBoard[1, 2] == 1 && Board.comBoard[2, 2] == 1)
            {
                return 1;
            }
            else if (Board.comBoard[0, 0] == 1 && Board.comBoard[1, 1] == 1 && Board.comBoard[2, 2] == 1)
            {
                return 1;
            }
            else if (Board.comBoard[0, 2] == 1 && Board.comBoard[1, 1] == 1 && Board.comBoard[2, 0] == 1)
            {
                return 1;
            }

            // DRAW - return 2
            if (howManyTurns == 9)
            {
                return 2; // DRAW
            }

            return 3; // no one wins for this time - dummy return
        }

        public static string ClickBoard(int row, int column)
        {
            if (howManyTurns % 2 == 0)
            {
                Board.userBoard[row, column] = 1;
                howManyTurns++;
                return "X";
            }
            else
            {
                Board.comBoard[row, column] = 1;
                howManyTurns++;
                return "O";
            }
        }
    }
}
