﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Clasess
{
    [Serializable]
    public class End
    {
        public int Id;
        public string Name;
        public string Description;
        public string DescriptionEng;
        public List<Parametrs> Result = new List<Parametrs>();
    }
}
