using BarterBound.Data.Enums;
using BarterBound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarterBound.Admin.Builders
{
    public class TextBlockBuilder
    {
        // manage the building of a scene
        private TextBlock _textBlock = new TextBlock();

        public void AddTriggerEvent(Event validEnum)
        {
            _textBlock.TriggerEvent = validEnum;
        }

        public bool CheckValidEvent(string eventString)
        {
            return Enum.TryParse(eventString, out Event x);
        }

        public Event GetTriggerEvent()
        {
            return _textBlock.TriggerEvent;
        }
    }
}
