using System;
namespace TicTacToe
{
    public class TakeTurn
    {
        public static void NextTurn(int counter, string[,] board)
        {
            int turnCounter = counter;
            string[,] turnBoard = board;

            Board.BoardLayout(turnBoard);

            if (counter % 2 == 0)
            {
                Console.WriteLine("Player 1, Select your square.");
            }
            else
            {
                Console.WriteLine("Player 2, Select your square.");
            }

            char move = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Validate.Move(turnCounter, turnBoard, move);

            turnCounter++;

        }
    }
}
