using System;

namespace TicTacToe
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            InitBoard();

        }

        public static void InitBoard()
        {
            int counter = 1;
            string[,] initBoard = {
                {"1", "2", "3"},
                {"4", "5", "6"},
                {"7", "8", "9"}
            };

            TakeTurn.NextTurn(counter, initBoard);

        }
    }
}
