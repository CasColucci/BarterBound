
using BarterBound.Data.Enums;
using static System.Console;

namespace BarterBound.Controllers
{
    internal class AdminController
    {
        internal void CreateScene()
        {
            Clear();
            WriteLine("What would you like to name the scene file? \n Scene File: ");
            string sceneName = ReadLine();
            Thread.Sleep(2000);
            WriteLine("Entering first text block. Beginning with OnStart Text.");
            NextActionEnum nextAction = NextActionEnum.OnStart;
            Thread.Sleep(2000);
            WriteLine("Begin adding TextValues now.");
            Thread.Sleep(2000);
            bool addingText = true;
            while (addingText)
            {
                MenuController menuController = new MenuController();
                string text = "";
                string prompt = "Is this spoken text or description text?";
                List<string> options = new List<string> { "Spoken", "Description", "Done Adding TextValues" };
                menuController.Menu(prompt, options);
                int selectedIndex = menuController.Run();
                switch (selectedIndex)
                {
                    case 0:
                        WriteLine("Enter the spoken text: ");
                        text += "/s" + ReadLine();
                        break;
                    case 1:
                        WriteLine("Enter the description text: ");
                        text += "/d" + ReadLine();
                        break;
                    case 2:
                        addingText = false;
                        break;
                    default:
                        break;
                }

            }
            WriteLine("What is the next action to follow this text block?");
            string theNextAction = ReadLine();
        }
    }
}