using BarterBound.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarterBound.Shared
{
    public class UserInputService
    {

        private IConsole _console;

        public UserInputService(IConsole console)
        {
            _console = console;
        }

        public string? GetUserInput()
        {
            return _console.ReadLine();
        }
    }
}
