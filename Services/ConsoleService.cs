﻿
using BarterBound.Services.Interfaces;
using static System.Console;

namespace BarterBound.Services;

internal class ConsoleService : IConsoleService
{
    public ConsoleColor ForegroundColor { get => ForegroundColor; set => ForegroundColor = value; }

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

    public void ResetColor()
    {
        ResetColor();
    }

    public void Clear()
    {
        Clear();
    }
}
