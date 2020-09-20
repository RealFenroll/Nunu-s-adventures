using Newtonsoft.Json;
using Nunu_s_Adventures.Entities.Interfaces;
using Nunu_s_Adventures.Entities.Models;
using System;
using System.IO;

namespace Nunu_s_Adventures.Entities
{
    public class CharacterService : ICharacterService
    {
        public Character LoadInitialCharacter()
        {
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}characters";
            var initialCharacter = new Character();

            if (File.Exists($"{basePath}\\nunu.json"))
            {
                var directory = new DirectoryInfo(basePath);
                var initialJsonFile = directory.GetFiles("nunu.json");

                using StreamReader fi = File.OpenText(initialJsonFile[0].FullName);
                initialCharacter = JsonConvert.DeserializeObject<Character>(fi.ReadToEnd());

            }
            return initialCharacter;

        }
    }
}
