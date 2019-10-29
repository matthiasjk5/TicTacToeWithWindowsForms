using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeWithWindowsForms
{
    class CalculateMark
    {
        // return 0: user wins. return 1: computer wins
        public int WhoWin()
        {
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
        }
    }
}
