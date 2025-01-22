using BarterBound.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarterBound.Models
{
    public class TextBlock
    {
        public Event TriggerEvent { get; set; }

        public List<string> TextValues { get; set; } = new List<string>();

        public Event NextEvent { get; set; }
    }
}
