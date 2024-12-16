using Assets.Scripts.Clasess;
using System.IO;
using UnityEngine;

namespace GameLogic.Functions.SaveLoad
{
    public class Save
    {
        private string folderPathInit => Path.Combine(Application.persistentDataPath, "Init");
        private string urlStart => Path.Combine(folderPathInit, "startGame.json");

        private string folderPathGame => Path.Combine(Application.persistentDataPath, "Game");
        private string urlGame => Path.Combine(folderPathGame, "players.json");

        public void SaveStartGame(Game startGame)
        {
            // Перевірка наявності папки
            if (!Directory.Exists(folderPathInit))
            {
                Directory.CreateDirectory(folderPathInit);
            }

            // Перетворення об'єкта у JSON-рядок
            string json = JsonUtility.ToJson(startGame);

            // Збереження у файл
            File.WriteAllText(urlStart, json);
            Debug.Log($"Saved Start Game data at: {urlStart}");
        }

        public void SavePlayers(Game players)
        {
            // Перевірка наявності папки
            if (!Directory.Exists(folderPathGame))
            {
                Directory.CreateDirectory(folderPathGame);
            }

            // Перетворення об'єкта у JSON-рядок
            string json = JsonUtility.ToJson(players);

            // Збереження у файл
            File.WriteAllText(urlGame, json);
            Debug.Log($"Saved Player data at: {urlGame}");
        }
    }
}
