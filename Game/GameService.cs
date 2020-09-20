using Nunu_s_Adventures.Adventures;
using Nunu_s_Adventures.Adventures.Interfaces;
using Nunu_s_Adventures.Entities;
using Nunu_s_Adventures.Entities.Interfaces;
using Nunu_s_Adventures.Entities.Models;
using System;
using System.ComponentModel;

namespace Nunu_s_Adventures.Game
{
    public class GameService
    {
        private IAdventureService adventureService;
        private ICharacterService characterService;
        Character objcharacter = new Character();

        public GameService(IAdventureService AdventureService, ICharacterService CharacterService)
        {
            adventureService = AdventureService;
            characterService = CharacterService;
        }
        public void StartGame()
        {
            MakeTitles.SFcreation();
            SaveFileCreation.addSaveFile();







            // case "Cavern":
            // break;
            // case "Mansion":

            // default:
            //   break;
            // }
            // var initialCharacter = characterService.LoadInitialCharacter();

            //   Console.WriteLine($"Adventure : {adventure.Title}");
            // Console.WriteLine($"Description : {adventure.Description}");
            // Console.WriteLine($"Name : {initialCharacter.Name}");
            // Console.WriteLine($"Description : {initialCharacter.Description}");
            //  }
            // catch (Exception ex)
            // {
            //    Console.WriteLine($"Oops! Something went wrong! { ex.Message}");
            //  }
        }

        public void LoadGame()
        {
            MakeTitles.SFLoad();
            SaveFileCreation.loadSaveFile();
        }
    }
}
