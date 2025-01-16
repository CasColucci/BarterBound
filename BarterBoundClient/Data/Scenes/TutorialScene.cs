using BarterBound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BarterBound.Data.Scenes
{
    internal class TutorialScene : Scene
    {
       public static string SceneName => "Tutorial";

       private List<TextBlock?> TextBlocks = new List<TextBlock?>();

        public void Run()
        {
            LoadTextBlocks();
            DisplayTextBlocks();
            PerformAction();
            NavigateToNextTextBlock();
        }
    }
}
