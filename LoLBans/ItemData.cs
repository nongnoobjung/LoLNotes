﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoLBans
{
    public class ItemData
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class ItemDatas : Dictionary<int, ItemData>
    {
    }
}