using Assets.Scripts.Clasess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GameLogic.Functions.SaveLoad
{
    public class Save
    {
        public string folderPathInit = "Init";
        public string urlStart = "Init/startGame.json";

        public string folderPathGame = "Game";
        public string urlGame = "Game/players.json";

        public void SaveStartGame(Game startGame)
        {
            // Перевірка наявності папки
            if (!Directory.Exists(folderPathInit))
            {
                // Якщо папка не існує, створіть її
                Directory.CreateDirectory(folderPathInit);
            }

            // Перетворення об'єкта у JSON-рядок
            string json = JsonUtility.ToJson(startGame);

            // Збереження у файл
            File.WriteAllText(urlStart, json);
        }

        public void SavePlayers(Game players)
        {
            // Перевірка наявності папки
            if (!Directory.Exists(folderPathGame))
            {
                // Якщо папка не існує, створіть її
                Directory.CreateDirectory(folderPathGame);
            }

            // Перетворення об'єкта у JSON-рядок
            string json = JsonUtility.ToJson(players);

            // Збереження у файл
            File.WriteAllText(urlGame, json);
        }
    }
}
