using BarterBound.Services.Interfaces;

namespace BarterBound.Tests.Controllers.ServicesTestable
{
    public class ConsoleServiceTestable : IConsoleService
    {
        public ConsoleColor ForegroundColor { get; set; }

        public void Write(string message)
        {

        }

        public void WriteLine(string message)
        {

        }

        public string ReadLine()
        {
            return "";
        }

        public void ResetColor()
        {

        }

        public void Clear()
        {

        }
    }
}
