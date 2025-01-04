﻿
using BarterBound.Data.Enums;
using BarterBound.Data.Scenes;
using BarterBound.Models;
using System.Xml;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;

namespace BarterBound.Controllers
{
    internal class AdminController
    {
        // method that runs the admin controller

        // method that starts a text block with a boolean to determine if it is the first text block
        private static string baseDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));

        private string relativePath = Path.Combine(baseDirectory, $@"Data\Scenes\SceneBlocks");

        public void Run()
        {
            Clear();
            // set up the model for the whole scene file
            var sceneBlock = new List<TextBlockModel>();

            // get a name for the file and check that this file is a unique name
            var sceneName = GetFileName();

            // get the first text block:
            // AddTextBlock with isFirst as true

            // add TextValues one at a time
            // add next Action
            sceneBlock.Add(AddTextBlock(true));
            
            // ask if the more inputs
            var moreBlocksMenu = new MenuController();
            var prompt = "Would you like to add another input?";
            var options = new List<string> { "Yes", "No" }; 
            moreBlocksMenu.Menu(prompt, options);

            var addingMoreBlocks = true;
            while(addingMoreBlocks)
            {
                int selectedIndex = moreBlocksMenu.Run();
                switch (selectedIndex)
                {
                    case 0:
                        sceneBlock.Add(AddTextBlock(false));
                        break;
                    case 1:
                        addingMoreBlocks = false;
                        break;
                    default:
                        break;

                }
            }

            WriteLine("Saving the values to the file!");
            Thread.Sleep(2000);
            // save completed scene to the TextBlocks file

            WriteFile(sceneName, sceneBlock);

        }

        private string GetFileName()
        {
            WriteLine("What would you like to name the scene? (This will be the name of the file)");

            var fileName = "";
            var validFile = false;
            

            while (!validFile)
            {
                fileName = ReadLine();
                var filePath = Path.Combine(relativePath, $"{fileName}.xml");
                var exists = File.Exists(filePath);
                if (exists)
                {
                    WriteLine("This file name already exists. Please write a new one.");
                }
                else if (fileName == null)
                {
                    WriteLine("Please enter a value");
                }
                else
                {
                    validFile = true;
                }
            }
            return fileName;
        }

        private TextBlockModel AddTextBlock(bool isFirstTextBlock)
        {
            var textBlock = new TextBlockModel();

            var triggerEvent = NextActionEnum.OnStart;
            if (!isFirstTextBlock)
            {
                WriteLine("What is the trigger event for this text block?");
                triggerEvent = ConvertInputToAction();
            }

            WriteLine("Begin adding TextValues now.");
            Thread.Sleep(2000);
            var textValues = GetTextValues();

            WriteLine("What is the Next Action to follow this one?");
            Thread.Sleep(2000);
            var nextAction = ConvertInputToAction();

            return textBlock;
        }

        private List<string> GetTextValues()
        {
            List<string> textValues = new List<string>();
            var text = "";

            MenuController textValueMenuController = new MenuController();
            string prompt = "Is this spoken text or description text?";
            List<string> options = new List<string> { "Spoken", "Description", "Done Adding TextValues" };
            textValueMenuController.Menu(prompt, options);

            bool addingText = true;

            while (addingText)
            {
                text = "";

                int selectedIndex = textValueMenuController.Run();
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
        private NextActionEnum ConvertInputToAction()
        {
            NextActionEnum result = NextActionEnum.None;
            bool notValid = true;
            while(notValid)
            {
                string input = ReadLine();
                if(Enum.TryParse(input, out NextActionEnum action))
                {
                    result = action;
                    notValid = false;
                }
                else
                {
                    WriteLine("That doesn't appear to be a valid input. Please try again or add the enum to the available options.");
                }
            }
            return result;
        }

        private void WriteFile(string sceneName, List<TextBlockModel> sceneBlock)
        {
            var scenePath = Path.Combine(relativePath, $"{sceneName}.xml");
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            XmlWriter writer = XmlWriter.Create(scenePath, settings);

            
        }
    }
}