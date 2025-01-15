using BarterBound.Data.Scenes;
using BarterBound.Services;
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
            List<string> options = new List<string> { "New", "Admin", "Exit" };
            menuController = new MenuController();
            menuController.Menu(prompt, options);
            int selectedIndex = menuController.Run();

            switch (selectedIndex)
            {
                case 0:
                    StartGame();
                    break;
                case 1:
                    AdminView();
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

        private void AdminView()
        {
            string prompt = "What would you like to do as an admin?";
            List<string> options = new List<string> { "Create a new Scene", "Exit" };
            MenuController adminMenuController = new MenuController();
            adminMenuController.Menu(prompt, options);
            int selectedIndex = adminMenuController.Run();

            switch (selectedIndex)
            {
                case 0:
                    var fileService = new FileService();
                    var console = new ConsoleService();
                    AdminController adminController = new AdminController(fileService, console);
                    adminController.Run();
                    break;
                case 1:
                    ExitGame();
                    break;
                default:
                    break;
            }
        }

        private void StartGame()
        {
            TutorialScene tutorialScene = new TutorialScene();
            tutorialScene.Run();
        }
    }
}
