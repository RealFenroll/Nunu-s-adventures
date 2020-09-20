using Nunu_s_Adventures.Adventures;
using Nunu_s_Adventures.Entities;
using Nunu_s_Adventures.Game;
using System;

namespace Nunu_s_Adventures
{
    class Program
    {
        private static AdventureService adventureService = new AdventureService();
        private static CharacterService characterService = new CharacterService();
        private static GameService gameService = new GameService(adventureService, characterService);
        static void Main(string[] args)
        {
            MakeTitles.MenuTitleScreen();
            MakeMenu();
        }


        private static void MakeMenu()
        {
            Console.WriteLine("\n(S)tart a new game");
            Console.WriteLine("(L)oad a character");
            Console.WriteLine("(O)ptions");
            Console.WriteLine(" ");
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
                        gameService.LoadGame();
                        InputValid = true;
                        break;
                    case "O":
                        Options();
                        InputValid = true;
                        break;
                    default:
                        Console.WriteLine("\nPlease enter a valid value");
                        Console.WriteLine("\n(S)tart a new game");
                        Console.WriteLine("(L)oad a character");
                        Console.WriteLine("(O)ptions");
                        Console.WriteLine(" ");
                        InputValid = false;
                        break;
                }
            }
        }

        private static void Options()
        {
            throw new NotImplementedException();
        }
    }
}
