using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel;
using System.Text.Json;
using Nunu_s_Adventures.Entities.Models;
using Newtonsoft.Json;
using Nunu_s_Adventures.Items.Models;
using Newtonsoft.Json.Linq;
using Nunu_s_Adventures.Adventures;

namespace Nunu_s_Adventures.Entities
{
    public class SaveFileCreation
    {
        public static object Response { get; private set; }
        public static object Character { get; private set; }

        private static void chooseSaveFile()
        {

        }

        public static void addSaveFile()
        {
            try
            {
                Console.WriteLine("\nWelcome, please create a save file.");
                Console.Write("\nPlease choose your name: ");
                string SFname = Console.ReadLine();
                StreamWriter sw = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}characters\\{SFname}.json");
                Console.Write("Please chose your password: ");
                string SFpassword = Console.ReadLine();
                Character objcharacter = new Character();
                objcharacter.Name = SFname;
                objcharacter.Password = SFpassword;
                objcharacter.Level = 1;
                string objjsonData = JsonConvert.SerializeObject(objcharacter);
                sw.Write(objjsonData);
                sw.Close();

                MakeTitles.AdventureTitleScreen();
                Console.WriteLine("\nSave File Loaded:");
                Console.WriteLine("Name: " + objcharacter.Name);
                Console.WriteLine("Level: " + objcharacter.Level);
            }


            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        public static void loadSaveFile()
        {
            Console.WriteLine("\nWelcome, please choose a Save File:");
            Console.WriteLine(" ");
            string path = ($"{AppDomain.CurrentDomain.BaseDirectory}characters");
            DirectoryInfo dr = new DirectoryInfo(path);
            FileInfo[] mFile = dr.GetFiles();
            foreach (FileInfo fiTemp in mFile)
            {
                Console.WriteLine(Path.GetFileNameWithoutExtension(fiTemp.Name));
            }
            Console.WriteLine(" ");
            string SFname = Console.ReadLine();
            try
            {
                var Character = new Character();
                var directory = new DirectoryInfo($"{AppDomain.CurrentDomain.BaseDirectory}characters");
                var JsonFile = directory.GetFiles($"{SFname}.json");

                using StreamReader fi = File.OpenText(JsonFile[0].FullName);
                Character = JsonConvert.DeserializeObject<Character>(fi.ReadToEnd());

                Console.Write("\nPlease Enter Your Password: ");
                string SFpassword = Console.ReadLine();
                try
                {
                    if (SFpassword == Character.Password)
                    {
                        MakeTitles.AdventureTitleScreen();

                    }

                }
                catch (Exception d)
                {

                    Console.WriteLine("Wrong Password!" + d.Message);
                }

            }
            catch (Exception sfname)
            {

                Console.WriteLine("Exception: " + sfname.Message);
            }

        }
    }
}  


