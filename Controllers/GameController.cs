using BarterBound.Data.Scenes;
using static System.Console;

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
            List<string> options = new List<string> { "New", "Load", "Exit" };
            menuController = new MenuController();
            menuController.Menu(prompt, options);
            int selectedIndex = menuController.Run();

            switch (selectedIndex)
            {
                case 0:
                    StartGame();
                    break;
                case 1:
                    LoadGame();
                    break;
                case 2:
                    ExitGame();
                    break;
                default:
                    break;
            }
            ExitGame();
        }

        private void ExitGame()
        {
            WriteLine("Press any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }

        private void LoadGame()
        {
            throw new NotImplementedException();
        }

        private void StartGame()
        {
            TutorialScene tutorialScene = new TutorialScene();
            tutorialScene.Run();
        }
    }
}
