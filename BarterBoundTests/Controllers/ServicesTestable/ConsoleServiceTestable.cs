using BarterBound.Services.Interfaces;

namespace BarterBound.Tests.Controllers.ServicesTestable
{
    public class ConsoleServiceTestable : IConsoleService
    {
        public string ToRead { get; set; } = "";

        public ConsoleColor ForegroundColor { get; set; }

        public void Write(string message)
        {

        }

        public void WriteLine(string message)
        {

        }

        public string ReadLine()
        {
            return ToRead;
        }

        public void ResetColor()
        {

        }

        public void Clear()
        {

        }
    }
}
