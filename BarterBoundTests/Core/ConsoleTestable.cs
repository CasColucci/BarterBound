using BarterBound.Core.Interfaces;

namespace BarterBound.Tests.Core;


public class ConsoleTestable : IConsole
{
    public ConsoleColor ForegroundColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public string lineToReturn = string.Empty;

    public string lastLineWritten = string.Empty;

    public ConsoleKeyInfo keyToReturn = new ConsoleKeyInfo('a', ConsoleKey.A, false, false, false);

    public void Clear()
    {
    }

    public void SetReadKey(ConsoleKeyInfo keyInfo)
    {
        keyToReturn = keyInfo;
    }

    public ConsoleKeyInfo ReadKey(bool intercept)
    {
        return keyToReturn;
    }

    // set a value to return when ReadLine is called
    public void SetReadLine(string input)
    {
        lineToReturn = input;
    }

    public string? ReadLine()
    {
        return lineToReturn; 
    }

    public void ResetColor()
    {
    }

    public void Write(string message)
    {
        lastLineWritten = message;
    }

    public void WriteLine(string message)
    {
        lastLineWritten = message;
    }

    internal string GetLastWrittenLine()
    {
        return lastLineWritten;
    }
}
