﻿using BarterBound.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarterBound.Models
{
    internal class TextBlockModel
    {
        public NextActionEnum TriggerEvent { get; set; }

        public List<string> TextValues { get; set; }

        public NextActionEnum NextAction { get; set; }
    }
}
