using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarterBound.Services.Interfaces
{
    public interface IConsoleService
    {
        void Write(string message);

        void WriteLine(string message);

        string ReadLine();

        void ResetColor();

        void Clear();
    }
}
