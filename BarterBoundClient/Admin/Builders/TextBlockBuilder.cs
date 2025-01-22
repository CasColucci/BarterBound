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

        public Event GetNextEvent()
        {
            return _textBlock.NextEvent;
        }

        public List<string> GetTextValues()
        {
            return _textBlock.TextValues;
        }

        public Event GetTriggerEvent()
        {
            return _textBlock.TriggerEvent;
        }

        public void SetNextEvent(Event nextEvent) 
        {
            _textBlock.NextEvent = nextEvent;
        }

        public void SetTextValues(List<string> textValues)
        {
            _textBlock.TextValues = textValues;
        }

        public void SetTriggerEvent(Event validEnum)
        {
            _textBlock.TriggerEvent = validEnum;
        }
    }
}
