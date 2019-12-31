using System;
namespace TicTacToe
{
    public class TakeTurn
    {
        public static void NextTurn(int counter, string[,] board)
        {
            int turnCounter = counter;
            string[,] turnBoard = board;
            string playerName;
            string player;

            // check for a draw.
            if (turnCounter == 10)
            {
                Console.WriteLine("This is a draw.  Press key to continue");
                Console.ReadKey();
                MainClass.InitBoard();
            }

            Board.BoardLayout(turnBoard);

            if (counter % 2 == 1)
            {
                playerName = "Player 1";
                player = "O";
                Console.WriteLine("{0}, Select your square.", playerName);
            }
            else
            {
                playerName = "Player 2";
                player = "X";
                Console.WriteLine("{0}, Select your square.", playerName);
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
            }
            else if (!validated)
            {
                NextTurn(counter, turnBoard);
            }

            if (Validate.Win(turnBoard))
            {
                switch (player)
                {

                    case "O":
                        Console.Clear();
                        Board.BoardLayout(turnBoard);
                        Console.WriteLine("{0} Wins.", playerName);
                        Console.WriteLine("Press a key to continue:");
                        Console.Read();
                        break;
                    case "X":
                        Console.Clear();
                        Board.BoardLayout(turnBoard);
                        Console.WriteLine("{0} Wins.", playerName);
                        Console.WriteLine("Press a key to continue:");
                        Console.Read();
                        break;
                }

                Console.Clear();
                MainClass.InitBoard();
            }


            turnCounter++;
            Console.Clear();
            NextTurn(turnCounter, turnBoard);

        }
    }
}
