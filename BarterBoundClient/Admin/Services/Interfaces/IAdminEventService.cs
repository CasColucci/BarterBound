using BarterBound.Data.Enums;

namespace BarterBound.Admin.Services.Interfaces;

public interface IAdminEventService
{
    public bool CheckValidEvent(string eventString);

    public Event ConvertStringToEvent(string eventString);
}
