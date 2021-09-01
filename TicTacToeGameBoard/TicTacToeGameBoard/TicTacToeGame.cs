using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGameBoard
{
   public class TicTacToeGame
    {

        //UC1
        public void InitializeBoard()
        {
            char[] board = new char[10];

            for (int i = 1; i < 10; i++)
                board[i] = ' ';
        }

    }
}
