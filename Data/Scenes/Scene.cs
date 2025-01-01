using BarterBound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using static System.Console;

namespace BarterBound.Data.Scenes
{
    public abstract class Scene
    {
        // scenes have the ability to navigate text blocks
        // it will display the text blocks in order with a break in between
        // it will then perform the action that follows the text block
        // it will then navigate to the next text block which follows, or will return to the town menu
        // it will get the text blocks via its own named file

        public string TextBlockLocation => @$"C:\Users\CRPad\source\repos\BarterBound\Data\Scenes\TextBlocks\{SceneName}.xml";

        public virtual string SceneName => "Tutorial";

        private TextBlockModel? TextBlocks = new TextBlockModel();

        public string CurrentEvent { get; set; }

        public Scene()
        {

        }

        public void Run()
        {   // load the text blocks
            LoadTextBlocks();

            // display the text blocks
            DisplayTextBlocks();

            // perform the action
            PerformAction();

            // navigate to the next text block
            NavigateToNextTextBlock();
        }
        
        protected void LoadTextBlocks()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(TextBlockLocation);
            XmlNodeList nodes = doc.SelectNodes("//TextBlocks/TextBlock");
            Console.WriteLine(TextBlocks);
        }

        protected void DisplayTextBlocks()
        {
            foreach(var text in TextBlocks.TextValues)
            {
                WriteLine(text);
                Thread.Sleep(2000);
            }
        }

        protected void PerformAction()
        {

        }

        protected void NavigateToNextTextBlock()
        {

        }
    }
}
