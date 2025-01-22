using BarterBound.Admin.Services.Interfaces;
using BarterBound.Data.Enums;
using BarterBound.Models;

namespace BarterBound.Admin.Builders
{
    public class TextBlockBuilder
    {
        // manage the building of a scene
        private TextBlock _textBlock = new TextBlock();
        private IAdminEventService _adminEventService;

        public TextBlockBuilder(IAdminEventService adminEventService)
        {
            _adminEventService = adminEventService;

        }

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

        public void SetNextEvent(string nextString) 
        {
            var nextEvent = _adminEventService.ConvertStringToEvent(nextString);
            if(nextEvent == Event.Invalid)
            {
                throw new ArgumentException();
            }
            else
            {
                _textBlock.NextEvent = nextEvent;
            }

        }

        public void SetTextValues(List<string> textValues)
        {
            _textBlock.TextValues = textValues;
        }

        public void SetTriggerEvent(string triggerString)
        {
            var triggerEvent = _adminEventService.ConvertStringToEvent(triggerString);
            if (triggerEvent == Event.Invalid)
            {
                throw new ArgumentException();
            }
            else 
            {
                _textBlock.TriggerEvent = triggerEvent;
            }
        }
    }
}
