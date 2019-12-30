using System;
namespace TicTacToe
{
    public class TakeTurn
    {
        public static void NextTurn(int counter, string[,] board)
        {
            int turnCounter = counter;
            string[,] turnBoard = board;
            string player;

            Board.BoardLayout(turnBoard);

            if (counter % 2 == 0)
            {
                player = "Player 1";
                Console.WriteLine("{0}, Select your square.", player);
            }
            else
            {
                player = "Player 2";
                Console.WriteLine("{0}, Select your square.", player);
            }

            char move = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int.TryParse(move.ToString(), out int nextMove);

            bool validated = Validate.Move(turnCounter, turnBoard, move);

            if (validated)
            {
                switch (nextMove)
                {
                    case 1:
                        turnBoard[0, 0] = player;
                        break;
                    case 2:
                        turnBoard[0, 1] = player;
                        break;
                    case 3:
                        turnBoard[0, 2] = player;
                        break;
                    case 4:
                        turnBoard[1, 0] = player;
                        break;
                    case 5:
                        turnBoard[1, 1] = player;
                        break;
                    case 6:
                        turnBoard[1, 2] = player;
                        break;
                    case 7:
                        turnBoard[2, 0] = player;
                        break;
                    case 8:
                        turnBoard[2, 1] = player;
                        break;
                    case 9:
                        turnBoard[2, 2] = player;
                        break;
                }

                Board.BoardLayout(turnBoard);
            }
            else if (!validated)
            {
                NextTurn(counter, turnBoard);
            }

            turnCounter++;
            NextTurn(turnCounter, turnBoard);

        }
    }
}
