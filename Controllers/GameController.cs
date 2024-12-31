using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarterBound.Controllers
{
    public class GameController
    {
        public MenuController menuController = null;

        public GameController() {
            
        }

        public void Run()
        {
            string prompt = @"
▀█████████▄     ▄████████    ▄████████     ███        ▄████████    ▄████████ ▀█████████▄   ▄██████▄  ███    █▄  ███▄▄▄▄   ████████▄  
  ███    ███   ███    ███   ███    ███ ▀█████████▄   ███    ███   ███    ███   ███    ███ ███    ███ ███    ███ ███▀▀▀██▄ ███   ▀███ 
  ███    ███   ███    ███   ███    ███    ▀███▀▀██   ███    █▀    ███    ███   ███    ███ ███    ███ ███    ███ ███   ███ ███    ███ 
 ▄███▄▄▄██▀    ███    ███  ▄███▄▄▄▄██▀     ███   ▀  ▄███▄▄▄      ▄███▄▄▄▄██▀  ▄███▄▄▄██▀  ███    ███ ███    ███ ███   ███ ███    ███ 
▀▀███▀▀▀██▄  ▀███████████ ▀▀███▀▀▀▀▀       ███     ▀▀███▀▀▀     ▀▀███▀▀▀▀▀   ▀▀███▀▀▀██▄  ███    ███ ███    ███ ███   ███ ███    ███ 
  ███    ██▄   ███    ███ ▀███████████     ███       ███    █▄  ▀███████████   ███    ██▄ ███    ███ ███    ███ ███   ███ ███    ███ 
  ███    ███   ███    ███   ███    ███     ███       ███    ███   ███    ███   ███    ███ ███    ███ ███    ███ ███   ███ ███   ▄███ 
▄█████████▀    ███    █▀    ███    ███    ▄████▀     ██████████   ███    ███ ▄█████████▀   ▀██████▀  ████████▀   ▀█   █▀  ████████▀  
                            ███    ███                            ███    ███                                                         
        Welcome to BarterBound! Choose an option with the arrow keys and press enter to select.";
            List<string> options = new List<string> { "Play", "About", "Exit" };
            menuController = new MenuController(prompt, options);
            menuController.Run();
        }

        private void ExitGame()
        {
            throw new NotImplementedException();
        }

        private void StartGame()
        {
            throw new NotImplementedException();
        }
    }
}
