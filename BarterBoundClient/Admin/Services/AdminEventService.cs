using BarterBound.Admin.Services.Interfaces;
using BarterBound.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarterBound.Admin.Services
{
    public class AdminEventService : IAdminEventService
    {
        public bool CheckValidEvent(string eventString)
        {
            var valid = Enum.TryParse(eventString, out Event newEvent);
            if (newEvent == Event.Invalid)
            {
                valid = false;
            }
            return valid;
        }

        public Event ConvertStringToEvent(string eventString)
        {
            Event value;
            if(CheckValidEvent(eventString))
            {
                Enum.TryParse(eventString, out Event newEvent);
                value = newEvent;
            }
            else
            {
                value = Event.Invalid;
                throw new ArgumentException("Unable to convert to Event, invalid string");
            }

            return value;
        }
    }
}
