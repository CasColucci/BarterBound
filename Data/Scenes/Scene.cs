﻿using BarterBound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarterBound.Data.Scenes
{
    public abstract class Scene
    {
        // scenes have the ability to navigate text blocks
        // it will display the text blocks in order with a break in between
        // it will then perform the action that follows the text block
        // it will then navigate to the next text block which follows, or will return to the town menu
        // it will get the text blocks via its own named file

        public string TextBlockLocation => $"Data/Scenes/TextBlocks/{SceneName}.json";

        public virtual string SceneName => "EmptyScene";

        private List<TextBlockModel> TextBlocks = new List<TextBlockModel>();

        public string CurrentEvent { get; set; }

        public Scene()
        {

        }

        public void Run()
        {             // load the text blocks
            LoadTextBlocks();

            // display the text blocks
            DisplayTextBlocks();

            // perform the action
            PerformAction();

            // navigate to the next text block
            NavigateToNextTextBlock();
        }
        
        private void LoadTextBlocks()
        {

        }

        private void DisplayTextBlocks()
        {

        }

        private void PerformAction()
        {

        }

        private void NavigateToNextTextBlock()
        {

        }
    }
}
