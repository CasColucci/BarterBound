using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarterBound.Controllers
{
    internal class MenuController : IMenuController
    {
        private int _selectedOption;
        private List<string> _options;
        private string _prompt;

        public void Menu(string prompt, List<string> options)
        {
            _prompt = prompt;
            _options = options;
            _selectedOption = 0;
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        private void DisplayOptions()
        {
            throw new NotImplementedException();
        }
    }
}
