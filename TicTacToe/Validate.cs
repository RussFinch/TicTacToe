using System;
namespace TicTacToe
{
    public class Validate
    {
        public static bool PlayerTurn(int counter, string[,] board, string move)
        {
            int vCounter = counter;
            string[,] vBoard = board;
            string vMove = move;
            bool result = false;

            ivalidate.keyEntered(move)

            return result;

        }

        public static bool Move(int counter, string[,] board, string move)
        {
            // Set result to automatically be false
            bool result = false;
            int vMove = 0;

            int.TryParse(move, out vMove);

            // If the entered move is acceptable continue
            if (move.Equals("1") || move.Equals("2") || move.Equals("3") ||
                move.Equals("4") || move.Equals("5") || move.Equals("6") ||
                move.Equals("7") || move.Equals("8") || move.Equals("9") ||
                !string.IsNullOrEmpty(move))
            {
                // Make sure the square has not already been used.
                if ((move.Equals("1") && (board[0, 0].Equals("x") || board[0, 0].Equals("o"))) ||
                    (move.Equals("2") && (board[0, 0].Equals("x") || board[0, 0].Equals("o"))) ||
                    (move.Equals("3") && (board[0, 0].Equals("x") || board[0, 0].Equals("o"))) ||
                    (move.Equals("4") && (board[0, 0].Equals("x") || board[0, 0].Equals("o"))) ||
                    (move.Equals("5") && (board[0, 0].Equals("x") || board[0, 0].Equals("o"))) ||
                    (move.Equals("6") && (board[0, 0].Equals("x") || board[0, 0].Equals("o"))) ||
                    (move.Equals("7") && (board[0, 0].Equals("x") || board[0, 0].Equals("o"))) ||
                    (move.Equals("8") && (board[0, 0].Equals("x") || board[0, 0].Equals("o"))) ||
                    (move.Equals("9") && (board[0, 0].Equals("x") || board[0, 0].Equals("o"))))
                {
                    Console.WriteLine("This square has alreadt been used.  Try again.");
                }


            }
            else
            {

                if (counter % 2 == 1)
                {
                    Console.WriteLine("Player 1, Please enter a valid move.");
                }
                else
                {
                    Console.WriteLine("Player 2, Please enter a valid move.");
                }
            }


            return result;

        }
    }
}
