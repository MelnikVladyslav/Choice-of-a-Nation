using Assets.Scripts.Clasess.Chois;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Clasess
{
    [Serializable]
    public class Turn
    {
        public int Id;
        public int IdTextCur = 0;
        public List<Content> Contents = new List<Content>();
        public List<Choise> Choises = new List<Choise>();
        public End End;
    }
}
