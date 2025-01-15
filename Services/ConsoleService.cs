
using static System.Console;

namespace BarterBound.Services;

internal class ConsoleService : IConsoleService
{
    public void WriteLine(string message)
    {
        WriteLine(message);
    }

    public void Write(string message)
    {
        Write(message);
    }

    public string ReadLine()
    {
        return ReadLine();
    }
}
