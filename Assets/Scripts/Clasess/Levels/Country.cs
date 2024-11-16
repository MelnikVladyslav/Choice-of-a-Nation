using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Clasess.Levels
{
    [Serializable]
    public class Country
    {
        public int Id;
        public string Name;
        public string Description;
        public string NameLeader;
        public string UrlLeader;
        public List<Turn> Turns = new List<Turn>();
        public List<Parametrs> Parametrs = new List<Parametrs>();
    }
}
