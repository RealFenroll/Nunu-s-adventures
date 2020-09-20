using Newtonsoft.Json;
using Nunu_s_Adventures.Entities.Interfaces;
using Nunu_s_Adventures.Entities.Models;
using System;
using System.IO;

namespace Nunu_s_Adventures.Entities
{
    public class CharacterService : ICharacterService
    {
        public Character LoadInitialCharacter(string name)
        {
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}characters";
            var initialCharacter = new Character();

            if (File.Exists($"{basePath}\\{name}.json"))
            {
                var directory = new DirectoryInfo(basePath);
                var initialJsonFile = directory.GetFiles($"{name}.json");

                using StreamReader fi = File.OpenText(initialJsonFile[0].FullName);
                initialCharacter = JsonConvert.DeserializeObject<Character>(fi.ReadToEnd());
            }
            else
            {
                throw new Exception("Character Can Not Be Found.");
            }
            return initialCharacter;
        }
    }
}
