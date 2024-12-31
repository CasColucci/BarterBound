using static System.Console;

namespace BarterBound.Controllers
{
    public class MenuController : IMenuController
    {
        private int _selectedIndex;
        private List<string> _options;
        private string _prompt;

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
                Clear();
                DisplayOptions();
                ConsoleKeyInfo keyInfo = ReadKey(true);
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
            Console.WriteLine(_prompt);
            for (int i = 0; i < _options.Count; i++)
            {
                string currentOption = _options[i];
                string prefix;

                if (i == _selectedIndex)
                {
                    prefix = "*";
                    ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    prefix = " ";
                    ForegroundColor = ConsoleColor.White;
                }

                WriteLine($"{prefix} << {currentOption} >>");
            }
            ResetColor();
        }

    }
}
