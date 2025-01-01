
using BarterBound.Data.Enums;
using BarterBound.Models;
using static System.Console;

namespace BarterBound.Controllers
{
    internal class AdminController
    {
        internal void CreateScene()
        {
            Clear();
            List<TextBlockModel> textBlocks = new List<TextBlockModel>();
            WriteLine("What would you like to name the scene file? \n Scene File: ");
            string sceneName = ReadLine();
            Thread.Sleep(2000);

            WriteLine("Entering first text block. Beginning with OnStart Text.");
            NextActionEnum triggerEvent = NextActionEnum.OnStart;
            Thread.Sleep(2000);

            WriteLine("Begin adding TextValues now.");
            Thread.Sleep(2000);

            List<string> textValues = GetTextValues();
             
            NextActionEnum nextAction = ConvertStringToAction();

            TextBlockModel textBlock = new TextBlockModel { 
                TextValues = textValues, TriggerEvent = triggerEvent, NextAction = nextAction };

        }

        internal NextActionEnum ConvertStringToAction()
        {
            bool notValid = true;
            while(notValid)
            {
                WriteLine("What is the next action to follow this text block?");
                string nextAction = ReadLine();
                if(Enum.TryParse(nextAction, out NextActionEnum action))
                {
                    return action;
                }
                else
                {
                    WriteLine("That doesn't appear to be a valid input. Please try again or add the enum to the available options.")
                }
            }
            throw new NotImplementedException();
        }

        private List<string> GetTextValues()
        {
            List<string> textValues = new List<string>();
            var text = "";

            MenuController menuController = new MenuController();
            string prompt = "Is this spoken text or description text?";
            List<string> options = new List<string> { "Spoken", "Description", "Done Adding TextValues" };
            menuController.Menu(prompt, options);

            bool addingText = true;

            while (addingText)
            {
                text = "";

                int selectedIndex = menuController.Run();
                switch (selectedIndex)
                {
                    case 0:
                        WriteLine("Enter the spoken text: ");
                        text += "/s" + ReadLine();
                        textValues.Add(text);
                        break;
                    case 1:
                        WriteLine("Enter the description text: ");
                        text += "/d" + ReadLine();
                        textValues.Add(text);
                        break;
                    case 2:
                        addingText = false;
                        break;
                    default:
                        break;
                }
            }

            return textValues;
        }
    }
}