using Newtonsoft.Json;
using Nunu_s_Adventures.Adventures;
using System;
using System.IO;

namespace Nunu_s_Adventures.Game
{
    public class GameService
    {
        public void StartGame()
        {
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}adventures";
            var initialAdventure = new Adventure();

            if (File.Exists($"{basePath}\\Initial.json"))
            {
                var directory = new DirectoryInfo(basePath);
                var initialJsonFile = directory.GetFiles("Initial.json");

                using StreamReader fi = File.OpenText(initialJsonFile[0].FullName);
                initialAdventure = JsonConvert.DeserializeObject<Adventure>(fi.ReadToEnd());
                Console.WriteLine($"Adventure : {initialAdventure.Title}");
                Console.WriteLine($"Description : {initialAdventure.Description}");
            }
        }
    }
}
