using System;
namespace TicTacToe
{
    public class Validate
    {
       
        public static bool Move(int counter, string[,] board, char move)
        {
            // Set result to automatically be false
            bool result = false;

            int.TryParse(move.ToString(), out int vMove);

            // If the entered move is acceptable continue
            if (vMove >= 1 && vMove <= 9)
            {
                // Make sure the square has not already been used.
                if (
                    (vMove.Equals(1) && (board[0, 0].Equals("X") || board[0, 0].Equals("O"))) ||
                    (vMove.Equals(2) && (board[0, 1].Equals("X") || board[0, 1].Equals("O"))) ||
                    (vMove.Equals(3) && (board[0, 2].Equals("X") || board[0, 2].Equals("O"))) ||
                    (vMove.Equals(4) && (board[1, 0].Equals("X") || board[1, 0].Equals("O"))) ||
                    (vMove.Equals(5) && (board[1, 1].Equals("X") || board[1, 1].Equals("O"))) ||
                    (vMove.Equals(6) && (board[1, 2].Equals("X") || board[1, 2].Equals("O"))) ||
                    (vMove.Equals(7) && (board[2, 0].Equals("X") || board[2, 0].Equals("O"))) ||
                    (vMove.Equals(8) && (board[2, 1].Equals("X") || board[2, 1].Equals("O"))) ||
                    (vMove.Equals(9) && (board[2, 2].Equals("X") || board[2, 2].Equals("O"))))
                {
                    Console.WriteLine("This square has already been used.  Try again.");
                    return result;
                }
                else
                {
                    TakeTurn.NextTurn()
                }


            }
            else
            {

                if (counter % 2 == 0)
                {
                    Console.WriteLine("Player 1, Please enter a valid move (1-9).");
                }
                else
                {
                    Console.WriteLine("Player 2, Please enter a valid move (1-9).");
                }
            }

            return result;

        }
    }
}
