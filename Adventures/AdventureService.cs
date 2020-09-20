using Newtonsoft.Json;
using Nunu_s_Adventures.Adventures.Interfaces;
using System;
using System.IO; 

namespace Nunu_s_Adventures.Adventures
{
    public class AdventureService : IAdventureService
    {
        public Adventure GetInitialAdventure()
        {
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}adventures";
            var initialAdventure = new Adventure();

            if (File.Exists($"{basePath}\\Initial.json"))
            {
                var directory = new DirectoryInfo(basePath);
                var initialJsonFile = directory.GetFiles("Initial.json");

                using StreamReader fi = File.OpenText(initialJsonFile[0].FullName);
                initialAdventure = JsonConvert.DeserializeObject<Adventure>(fi.ReadToEnd());

            }
            return initialAdventure;

        }
    }
}
