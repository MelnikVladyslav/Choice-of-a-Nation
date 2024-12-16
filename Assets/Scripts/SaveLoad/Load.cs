using Assets.Scripts.Clasess;
using System.IO;
using UnityEngine;

namespace GameLogic.Functions.SaveLoad
{
    public class Load
    {
        private string urlStart => Path.Combine(Application.persistentDataPath, "Init", "startGame.json");
        private string urlGame => Path.Combine(Application.persistentDataPath, "Game", "players.json");

        public Game LoadStartInfo()
        {
            if (File.Exists(urlStart))
            {
                // Зчитування JSON з файлу
                string jsonFromFile = File.ReadAllText(urlStart);

                // Перетворення JSON у об'єкт
                Game deserializedStartGame = JsonUtility.FromJson<Game>(jsonFromFile);

                Debug.Log($"Loaded Start Game data from: {urlStart}");
                return deserializedStartGame;
            }
            else
            {
                Debug.LogWarning("Start Game file not found.");
                return null;
            }
        }

        public Game LoadPlayersInfo()
        {
            if (File.Exists(urlGame))
            {
                // Зчитування JSON з файлу
                string jsonFromFile = File.ReadAllText(urlGame);

                // Перетворення JSON у об'єкт
                Game deserializedPlayers = JsonUtility.FromJson<Game>(jsonFromFile);

                Debug.Log($"Loaded Player data from: {urlGame}");
                return deserializedPlayers;
            }
            else
            {
                Debug.LogWarning("Players file not found.");
                return null;
            }
        }
    }
}
