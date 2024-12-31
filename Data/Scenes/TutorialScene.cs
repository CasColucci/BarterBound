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
       public string SceneName => "Tutorial";

       private List<TextBlockModel?> TextBlocks = new List<TextBlockModel?>();

        public void Run()
        {
            LoadTextBlocks();
            DisplayTextBlocks();
            PerformAction();
            NavigateToNextTextBlock();
        }
    }
}
