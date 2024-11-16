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
    public class Load
    {
        public string urlStart = "Init/startGame.json";
        public string urlGame = "Game/players.json";

        public Game LoadStartInfo()
        {
            // Зчитування JSON з файлу
            string jsonFromFile = File.ReadAllText(urlStart);

            // Перетворення JSON у об'єкт
            Game deserializedStartGame = JsonUtility.FromJson<Game>(jsonFromFile);

            return deserializedStartGame;
        }

        public Game LoadPlayersInfo()
        {
            // Зчитування JSON з файлу
            string jsonFromFile = File.ReadAllText(urlGame);

            // Перетворення JSON у об'єкт
            Game deserializedPlayers = JsonUtility.FromJson<Game>(jsonFromFile);

            return deserializedPlayers;
        }
    }
}
