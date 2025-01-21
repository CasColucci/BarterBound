using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarterBound.Core.Interfaces
{
    public interface IConsole
    {
        ConsoleColor ForegroundColor { get; set; }

        void Write(string message);

        void WriteLine(string message);

        string? ReadLine();

        void ResetColor();

        void Clear();
        ConsoleKeyInfo ReadKey(bool intercept);
    }
}
