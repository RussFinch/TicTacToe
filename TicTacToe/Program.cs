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
            int counter = 0;
            string[,] initBoard = {
                {"1", "2", "3"},
                {"4", "5", "6"},
                {"7", "8", "9"}
            };

            Board.BoardLayout(initBoard);

            Console.WriteLine("Player 1, Select your square");
            char move = Console.ReadKey().KeyChar;

            Validate.Move(counter, initBoard, move);


        }
    }
}
