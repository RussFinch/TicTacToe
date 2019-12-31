using System;

namespace TicTacToe
{
    public class Board
    {
        public static void BoardLayout(string[,] playerPositions)
        {
            string[,] board = playerPositions;

            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", board[2, 0], board[2, 1], board[2, 2]);
            Console.WriteLine("   |   |   ");

        }
    }
}
