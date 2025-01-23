using BarterBound.Admin.Services.Interfaces;
using BarterBound.Data.Enums;
using BarterBound.Models;

namespace BarterBound.Admin.Builders
{
    /// <summary>
    /// Build the object "Text Block", which stores a trigger event, text values, 
    /// and a next event.
    /// </summary>
    public class TextBlockBuilder
    {
        private TextBlock _textBlock = new TextBlock();
        private IAdminEventService _adminEventService;

        /// <summary>
        /// Build the object "Text Block", which stores a trigger event, 
        /// text values, and a next event.
        /// </summary>
        /// <param name="adminEventService"></param>
        public TextBlockBuilder(IAdminEventService adminEventService)
        {
            _adminEventService = adminEventService;

        }

        /// <summary>
        /// Get the next event to follow the text values
        /// </summary>
        /// <returns>next Event from the TextBlock</returns>
        public Event GetNextEvent()
        {
            return _textBlock.NextEvent;
        }

        /// <summary>
        /// Get the text values for the TextBlock
        /// </summary>
        /// <returns>the text values</returns>
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
