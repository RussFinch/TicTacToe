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

        public static void validate(string[,] currentBoard)
        {
            string[,] validateBoard = currentBoard;

            // Validate Horizontal winning lines
            if (((validateBoard[0, 0] == validateBoard[0, 1]) && (validateBoard[0, 1] == validateBoard[0, 2])) ||
                ((validateBoard[1, 0] == validateBoard[1, 1]) && (validateBoard[1, 1] == validateBoard[1, 2])) ||
                ((validateBoard[2, 0] == validateBoard[2, 1]) && (validateBoard[2, 1] == validateBoard[2, 2])) ||
            // Validate Vertical winning lines
                ((validateBoard[0, 0] == validateBoard[1, 0]) && (validateBoard[1, 0] == validateBoard[2, 0])) ||
                ((validateBoard[0, 1] == validateBoard[1, 1]) && (validateBoard[1, 1] == validateBoard[2, 1])) ||
                ((validateBoard[0, 2] == validateBoard[1, 2]) && (validateBoard[1, 2] == validateBoard[2, 2])) ||
            // Vlaidate Diagonal winning lines
                ((validateBoard[0, 0] == validateBoard[1, 1]) && (validateBoard[1, 1] == validateBoard[2, 2])) ||
                ((validateBoard[0, 2] == validateBoard[1, 1]) && (validateBoard[1, 1] == validateBoard[2, 0])))
            {
                string caseSwitch = validateBoard[0, 0];

                switch (caseSwitch)
                {

                    case "O":
                        Console.WriteLine("Player 1 Wins.");
                        Console.WriteLine("Press a key to continue:");
                        Console.Read();
                        break;
                    case "X":
                        Console.WriteLine("Player 2 Wins.");
                        Console.WriteLine("Press a key to continue:");
                        Console.Read();
                        break;


                }

                BoardLayout(validateBoard);
            }

        }
    }
}
