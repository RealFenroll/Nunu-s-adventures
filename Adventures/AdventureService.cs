using Newtonsoft.Json;
using Nunu_s_Adventures.Adventures.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Nunu_s_Adventures.Adventures
{
    public class AdventureService : IAdventureService
    {
        public Adventure LoadAdventure(string name)
        {
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}adventures";
            var initialAdventure = new Adventure();

            if (File.Exists($"{basePath}\\{name}.json"))
            {
                var directory = new DirectoryInfo(basePath);
                var initialJsonFile = directory.GetFiles($"{name}.json");

                using StreamReader fi = File.OpenText(initialJsonFile[0].FullName);
                initialAdventure = JsonConvert.DeserializeObject<Adventure>(fi.ReadToEnd());
                return initialAdventure;
            }
            return initialAdventure;
        }

    }
}
