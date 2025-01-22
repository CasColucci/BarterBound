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
    }
}
