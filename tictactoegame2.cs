using System;

namespace tictactoeee
{
    class Program
    {
         enum Menu { New = 1, Author, Exit }

        static void Main(string[] args)
        {
            Menu M;
            bool exit = false;
            do
            {
                Console.Clear();
                Console.WriteLine("WELCOME TO THE TICTACTOE GAME!\n");
                Console.WriteLine("1. New game\n2. About the author\n" +
                       "3. Exit");
                Console.WriteLine("Enter 1, 2 or 3 according to the above.");

                while (!Enum.TryParse<Menu>(Console.ReadKey().KeyChar.ToString(), out M)) ;

                Console.Clear();

                switch (M)
                {
                    case Menu.New:
                        char A1, A2, A3, A4, A5, A6, A7, A8, A9, A = 'X';
                        A1 = A2 = A3 = A4 = A5 = A6 = A7 = A8 = A9 = ' ';
                        int i = 0;                        
                        bool win=false;

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\n" + A1 + "|" + A2 + "|" + A3 + "\n-----\n" +
                                                   A4 + "|" + A5 + "|" + A6 + "\n-----\n" +
                                                   A7 + "|" + A8 + "|" + A9 + "\n");

                            if (++i > 9 || win)
                                break;

                            bool ok = false;

                            do
                            {
                                Console.Write(A + "'s move > ");
                                switch (Console.ReadKey().KeyChar)
                                {
                                    case '1': if (A1 == ' ')
                                        {
                                            A1 = A; ok = true;
                                            win = A2 == A && A3 == A 
                                               || A4 == A && A7 == A
                                               || A5 == A && A9 == A;
                                        }
                                        break;
                                    case '2': if (A2 == ' ')
                                        {
                                            A2 = A; ok = true;
                                            win = A1 == A && A3 == A
                                               || A5 == A && A8 == A;
                                        }
                                        break;
                                    case '3': if (A3 == ' ')
                                        {
                                            A3 = A; ok = true;
                                            win = A1 == A && A2 == A
                                               || A6 == A && A9 == A
                                               || A5 == A && A7 == A;
                                        }
                                        break;
                                    case '4': if (A4 == ' ')
                                        {
                                            A4 = A; ok = true;
                                            win = A5 == A && A6 == A 
                                               || A1 == A && A7 == A;
                                        }
                                        break;
                                    case '5': if (A5 == ' ')
                                        {
                                            A5 = A; ok = true;
                                            win = A4 == A && A6 == A 
                                               || A2 == A && A8 == A
                                               || A1 == A && A9 == A
                                               || A3 == A && A7 == A;
                                        }
                                        break;
                                    case '6': if (A6 == ' ')
                                        {
                                            A6 = A; ok = true;
                                            win = A4 == A && A5 == A 
                                               || A3 == A && A9 == A;
                                        }
                                        break;
                                    case '7': if (A7 == ' ')
                                        {
                                            A7 = A; ok = true;
                                            win = A8 == A && A9 == A 
                                               || A1 == A && A4 == A
                                               || A3 == A && A5 == A;
                                        }
                                        break;
                                    case '8': if (A8 == ' ')
                                        {
                                            A8 = A; ok = true;
                                            win = A7 == A && A9 == A 
                                               || A2 == A && A5 == A;
                                        }
                                        break;
                                    case '9': if (A9 == ' ')
                                        {
                                            A9 = A; ok = true;
                                            win = A7 == A && A8 == A
                                               || A3 == A && A6 == A
                                               || A1 == A && A5 == A;
                                        }
                                        break;
                                }
                                if (!ok)
                                    Console.WriteLine("Illegal move! Try again.");
                            } while (!ok);

                            if(!win)
                                if (A == 'X')
                                    A = 'O';
                                else
                                    A = 'X';
                        } while (true);

                        if (win)
                            Console.WriteLine(A + " won!");
                        else
                            Console.WriteLine("Game over!");
                        Console.WriteLine("[Press Enter to return to main menu...]");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                        break;
                    case Menu.Author:
                        Console.WriteLine("About the author.");
                        Console.WriteLine("[Press Enter to return to main menu...]");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                        break;
                    case Menu.Exit:
                        Console.Write("Exit? [y/n]");
                        if (Console.ReadKey().KeyChar == 'y')
                            exit= true;
                        else
                            Console.Clear();
                        break;
                }
            } while (!exit);
        }
    }
}
