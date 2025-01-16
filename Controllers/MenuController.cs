using BarterBound.Services.Interfaces;
using static System.Console;

namespace BarterBound.Controllers
{
    public class MenuController
    {
        private readonly IConsoleService _console;
        private readonly IConsoleInputService _consoleInputService;

        private int _selectedIndex;
        private List<string> _options = new List<string>();
        private string _prompt = "";

        public MenuController(IConsoleService console, IConsoleInputService consoleInputService)
        {
            _console = console;
            _consoleInputService = consoleInputService;
        }

        public void Menu(string prompt, List<string> options)
        {
            _prompt = prompt;
            _options = options;
            _selectedIndex = 0;
        }

        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                _console.Clear();
                DisplayOptions();
                ConsoleKeyInfo keyInfo = _consoleInputService.ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    _selectedIndex--;
                    if (_selectedIndex < 0)
                    {
                        _selectedIndex = _options.Count - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    _selectedIndex++;
                    if (_selectedIndex >= _options.Count)
                    {
                        _selectedIndex = 0;
                    }
                }

            } while (keyPressed != ConsoleKey.Enter);
            return _selectedIndex;
        }

        private void DisplayOptions()
        {
            _console.WriteLine(_prompt);
            for (int i = 0; i < _options.Count; i++)
            {
                string currentOption = _options[i];
                string prefix;

                if (i == _selectedIndex)
                {
                    prefix = "*";
                    _console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    prefix = " ";
                    _console.ForegroundColor = ConsoleColor.White;
                }

                _console.WriteLine($"{prefix} << {currentOption} >>");
            }
            _console.ResetColor();
        }

    }
}
