using Assets.Scripts.Clasess.Levels;
using Assets.Scripts.Clasess.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Clasess
{
    [Serializable]
    public class Game
    {
        public int Id;
        public Player PlayerData;
        public List<Level> Levels = new List<Level>();
        public List<Achievements> Achievements = new List<Achievements>();
    }
}
