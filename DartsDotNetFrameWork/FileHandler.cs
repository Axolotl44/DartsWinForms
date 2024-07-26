using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace DartsDotNetFrameWork
{
    internal static class FileHandler //TO BE UPDATED
    {
        //Player Save/Load
        public static Player LoadPlayer(string fileName)
        {
            string filePath = $@"SavedGames\{fileName}.json";

            if (File.Exists(filePath))
            {
                string allText = File.ReadAllText(filePath);

                Player p = JsonConvert.DeserializeObject<Player>(allText);

                return p;
            }
            return null;
        }

        public static void SavePlayer(Player p, string fileName)
        {
            string jsonContent = JsonConvert.SerializeObject(p, Formatting.Indented);

            string filePath = $@"SavedGames\{fileName}.json";

            if (!(File.Exists(filePath)))
            {
                File.WriteAllText(filePath, jsonContent);
            }
            else {FileAlreadyExists(filePath, jsonContent); }
        }


        //Game Save/Load
        public static Game LoadGame(string fileName)
        {
            string filePath = $@"SavedGames\{fileName}.json";

            if (File.Exists(filePath))
            {
                string allText = File.ReadAllText(filePath);

                Game g = JsonConvert.DeserializeObject<Game>(allText);

                return g;
            }
            return null;
        }

        public static void SaveGame(Game g, string fileName)
        {
            string jsonContent = JsonConvert.SerializeObject(g, Formatting.Indented);

            string filePath = $@"SavedGames\{fileName}.json";

            if (!(File.Exists(filePath)))
            {
                File.WriteAllText(filePath, jsonContent);
            }
            else { FileAlreadyExists(filePath, jsonContent); }
        }


        private static void FileAlreadyExists(string path, string content)
        {
            //Console.WriteLine("\nMár létezik ilyen file\n1. felülírás\n2. mentés másként\n3. kilépés mentés nélkül\n1/2/3?");
            //string option = Console.ReadLine();
            //switch (option)
            //{
            //    case "1":
            //        Console.Clear();
            //        Console.WriteLine("Felülírva");
            //        File.WriteAllText(path, content);
            //        break;

            //    case "2":
            //        Console.Clear();
            //        Console.WriteLine("Adjon meg egy file nevet:");
            //        string fileName = Console.ReadLine();
            //        path = $@"SavedGames\{fileName}.json";
            //        File.WriteAllText(path, content);
            //        break;

            //    case "3":
            //        Console.Clear();
            //        Console.WriteLine("Kilépés..");
            //        break;

            //    default:
            //        Console.WriteLine("Adjon meg valós értéket");
            //        FileAlreadyExists(path, content);
            //        break;
            //}
        }



    }
}
