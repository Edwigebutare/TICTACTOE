using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            int game = 0;
            int Player1 = -1;
            char[] fieldnumber = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            do
            {
                Console.Clear();

                Player1 = GetNextPlayer(Player1);

                HeadsUpDisplay(Player1);
                DrawGameboard(fieldnumber);

                GameEngine(fieldnumber, Player1);

                // 3.1 After each turn judge if there is a winner
                // 3.2 If no winner keep playing by going to step 1.
                game = CheckWinner(fieldnumber);

            } while (game.Equals(0));

            Console.Clear();
            HeadsUpDisplay(Player1);
            DrawGameboard(fieldnumber);

            if (game.Equals(1))
            {
                Console.WriteLine($"Player {Player1} is the winner!");
            }

            if (game.Equals(2))
            {
                Console.WriteLine($"The game is a draw!");
            }
        }

        private static int CheckWinner(char[] fieldnumber)
        {
            // 3.3 If all markers are placed and no winner then it's a draw stop the game
            if (IsGameDraw(fieldnumber))
            {
                return 2;
            }

            // 3.3 If we have a winner, announce who won and stop the game
            if (IsGameWinner(fieldnumber))
            {
                return 1;
            }

            return 0;
        }

        
        }

    private static bool IsGameDraw(char[] fieldnumber)
    {
        return fieldnumber[0] != '1' &&
               fieldnumber[1] != '2' &&
               fieldnumber[2] != '3' &&
               fieldnumber[3] != '4' &&
               fieldnumber[4] != '5' &&
               fieldnumber[5] != '6' &&
               fieldnumber[6] != '7' &&
               fieldnumber[7] != '8' &&
               fieldnumber[8] != '9';
    }

    private static bool IsGameWinner(char[] fieldnumber)
        {
            if (IsfieldnumberTheSame(fieldnumber, 0, 1, 2))
            {
                return true;
            }

            if (IsfieldnumberTheSame(fieldnumber, 3, 4, 5))
            {
                return true;
            }

            if (IsfieldnumberTheSame(fieldnumber, 6, 7, 8))
            {
                return true;
            }

            if (IsfieldnumberTheSame(fieldnumber, 0, 3, 6))
            {
                return true;
            }

            if (IsfieldnumberTheSame(fieldnumber, 1, 4, 7))
            {
                return true;
            }

            if (IsfieldnumberTheSame(fieldnumber, 2, 5, 8))
            {
                return true;
            }

            if (IsfieldnumberTheSame(fieldnumber, 0, 4, 8))
            {
                return true;
            }

            if (IsfieldnumberTheSame(fieldnumber, 2, 4, 6))
            {
                return true;
            }

            return false;
        }

        private static bool IsfieldnumberTheSame(char[] testfieldnumber, int pos1, int pos2, int pos3)
        {
            return testfieldnumber[pos1].Equals(testfieldnumber[pos2]) && testfieldnumber[pos2].Equals(testfieldnumber[pos3]);
        }

        private static void GameEngine(char[] fieldnumber, int Player1)
        {
            bool notValidMove = true;

            do
            {
                // 3.  As the user places markers on the game update the board then notify which player has a turn
                string userInput = Console.ReadLine();

                if (!string.IsNullOrEmpty(userInput) &&
                    (userInput.Equals("1") ||
                    userInput.Equals("2") ||
                    userInput.Equals("3") ||
                    userInput.Equals("4") ||
                    userInput.Equals("5") ||
                    userInput.Equals("6") ||
                    userInput.Equals("7") ||
                    userInput.Equals("8") ||
                    userInput.Equals("9")))
                {

                    int.TryParse(userInput, out var fieldPlacementnumber);

                    char currentfield = fieldnumber[fieldPlacementnumber - 1];

                    if (currentfield.Equals('X') || currentfield.Equals('O'))
                    {
                        Console.WriteLine("Illegal move! Try again.");
                    }
                    else
                    {
                        fieldnumber[fieldPlacementnumber - 1] = GetPlayerMarker(Player1);

                        notValidMove = false;
                    }
                }
                else
                {
                    Console.WriteLine("Illegal move! Try again.");
                }
            } while (notValidMove);
        }

        private static char GetPlayerMarker(int player2)
        {
            if (player2 % 2 == 0)
            {
                return 'O';
            }

            return 'X';
        }

        static void HeadsUpDisplay(int PlayerNumber)
        {
            // 1.  Provide instructions
            // 1.1 A greeting
            Console.WriteLine("Welcome to tic-tac-toe!");

            // 1.2 Display player sign, Player 1 is X and Player 2 is O
            // Console.WriteLine("Player 1: X");
            // Console.WriteLine("Player 2: O");
            Console.WriteLine();

            // 1.3 Who's turn is it?
            // 1.4 Instruct the user to enter a number between 1 and 9
            // Console.WriteLine($"Player {PlayerNumber} to move, select 1 thorugh 9 from the game board.");
            Console.WriteLine();
        }

        static void DrawGameboard(char[] fieldnumber)
        {
            // 2.  Draw the game board
            // 2.1 Game will have 3 rows and 3 columns will be numbered 1 through 9

            Console.WriteLine($" {fieldnumber[0]} | {fieldnumber[1]} | {fieldnumber[2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {fieldnumber[3]} | {fieldnumber[4]} | {fieldnumber[5]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {fieldnumber[6]} | {fieldnumber[7]} | {fieldnumber[8]} ");
        }

        static int GetNextPlayer(int player2)
        {
            if (player2.Equals(1))
            {
                return 2;
            }

            return 1;
        }
    }
}
