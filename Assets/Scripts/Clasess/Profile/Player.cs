using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Clasess.Profile
{
    [Serializable]
    public class Player
    {
        public int Id;
        public string Name;
        public string Email;
        public List<Achievements> AchievementsOpen = new List<Achievements>();
    }
}
