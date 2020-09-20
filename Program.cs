using Nunu_s_Adventures.Game;
using System;

namespace Nunu_s_Adventures
{
    class Program
    {
        private static GameService gameService = new GameService();
        static void Main(string[] args)
        {
            TitleScreen();
            MakeMenu();
        }


        private static void TitleScreen()
        {
            Console.SetWindowSize(150, 50);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"         __  __                           __               ______      __                         __                                  ");
            Console.WriteLine(@"        /\ \/\ \                         /\ \             /\  _  \    /\ \                       /\ \__                               ");
            Console.WriteLine(@"        \ \  \\ \  __  __    ___   __  __\ \/      ____   \ \ \L\ \   \_\ \  __  __     __    ___\ \ ,_\  __  __  _ __    __    ____  ");
            Console.WriteLine(@"         \ \ , ` \/\ \/\ \ /' _ `\/\ \/\ \\/      /',__\   \ \  __ \  /'_` \/\ \/\ \  /'__`\/' _ `\ \ \/ /\ \/\ \/\  __\/'__`\ /',__\ ");
            Console.WriteLine(@"          \ \ \`\ \ \ \_\ \/\ \/\ \ \ \_\ \      /\__, `\   \ \ \/\ \/\ \L\ \ \ \_/ |/\  __//\ \/\ \ \ \_\ \ \_\ \ \ \//\  __//\__, `\");
            Console.WriteLine(@"           \ \_\ \_\ \____/\ \_\ \_\ \____/      \/\____/    \ \_\ \_\ \_____\ \___/ \ \____\ \_\ \_\ \__\\ \____/\ \_\\ \____\/\____/");
            Console.WriteLine(@"            \/_/\/_/\/___/  \/_/\/_/\/___/        \/___/      \/_/\/_/\/____ /\/__/   \/____/\/_/\/_/\/__/ \/___/  \/_/ \/____/\/___/ ");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\nWelcome to the game of Nunu's Adventures!");
            Console.WriteLine("No Idea what this is about!");
        }
        private static void MakeMenu()
        {
            Console.WriteLine("\n(S)tart a new game");
            Console.WriteLine("(L)oad a character");
            Console.WriteLine("(O)ptions");
            var InputValid = false;

            while (!InputValid)
            {
                switch (Console.ReadLine().ToUpper())
                {
                    case "S":
                        gameService.StartGame();
                        InputValid = true;
                        break;
                    case "L":
                        LoadGame();
                        InputValid = true;
                        break;
                    case "O":
                        Options();
                        InputValid = true;
                        break;
                    default:
                        Console.WriteLine("\nYou didn't ented a valid value");
                        Console.WriteLine("\n(S)tart a new game");
                        Console.WriteLine("(L)oad a character");
                        Console.WriteLine("(O)ptions");
                        InputValid = false;
                        break;
                }
            }
        }

        private static void Options()
        {
            Console.WriteLine("Optins loaded!");
        }

        private static void LoadGame()
        {
            Console.WriteLine("Game loaded!");
        }
    }
}
