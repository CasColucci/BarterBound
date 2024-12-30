using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarterBound.Controllers
{
    public interface IMenuController
    {
        public void Menu(string prompt, List<string> options);

        public void Run();

        private void DisplayOptions();
    }
}
