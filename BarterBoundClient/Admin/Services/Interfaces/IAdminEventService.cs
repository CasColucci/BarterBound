using BarterBound.Data.Enums;

namespace BarterBound.Admin.Services.Interfaces;

/// <summary>
/// A service to handle event validation and event conversion from string
/// </summary>
public interface IAdminEventService
{
    /// <summary>
    /// Take in a string and confirm whether it can be converted into an Event. Will return false
    /// if so. 
    /// </summary>
    /// <param name="eventString"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public bool CheckValidEvent(string eventString);

    /// <summary>
    /// Take in a string and convert to an enum type named Event. Will throw ArgumentException if the value created is the invalid 
    /// unset value, or is otherwise unable to be converted.
    /// </summary>
    /// <param name="eventString"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public Event ConvertStringToEvent(string eventString);
}
