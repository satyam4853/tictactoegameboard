using System;

namespace TicTacToeGameBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tWelcome To Tic-Tac-Toe-Board Assignment");
            TicTacToeGame tictactoegame = new TicTacToeGame();
            tictactoegame.InitializeBoard();
            tictactoegame.ChooseOption();
            tictactoegame.ShowBoard();
        }
    }
}
