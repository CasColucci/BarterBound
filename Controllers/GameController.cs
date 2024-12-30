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
            Console.WriteLine("GameController created");
        }

        public void Run()
        {
            menuController = new MenuController();
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
