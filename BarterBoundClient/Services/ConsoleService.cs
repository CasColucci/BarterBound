
using BarterBound.Services.Interfaces;
using static System.Console;

namespace BarterBound.Services;

internal class ConsoleService : IConsoleService
{
    public ConsoleColor ForegroundColor { get => Console.ForegroundColor; set => Console.ForegroundColor = value; }

    public void WriteLine(string message)
    {
        Console.WriteLine(message);
    }

    public void Write(string message)
    {
        Console.Write(message);
    }

    public string? ReadLine()
    {
        return Console.ReadLine();
    }

    public void ResetColor()
    {
        Console.ResetColor();
    }

    public void Clear()
    {
        Console.Clear();
    }
}
