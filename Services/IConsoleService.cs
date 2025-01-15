using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarterBound.Services
{
    interface IConsoleService
    {
        void Write(string message);

        void WriteLine(string message);

        string ReadLine();
    }
}
