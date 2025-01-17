using BarterBound.Core.Interfaces;

namespace BarterBound.Tests.Controllers.ServicesTestable
{
    public class ConsoleTestable : IConsole
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

        public ConsoleKeyInfo ReadKey(bool intercept)
        {
            throw new NotImplementedException();
        }
    }
}
