﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Clasess.Choise
{
    [Serializable]
    public class Choise
    {
        public int Id;
        public string Name;
        public List<ElementChoise> Elements;
    }
}
