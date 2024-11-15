using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Clasess.Levels
{
    [Serializable]
    public class Level
    {
        public int Id;
        public string Name;
        public string Description;
        public List<Country> CountriesOpen = new List<Country>();
    }
}
