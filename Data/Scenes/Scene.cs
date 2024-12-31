using BarterBound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarterBound.Data.Scenes
{
    internal class Scene
    {
        // scenes have the ability to navigate text blocks
        // it will display the text blocks in order with a break in between
        // it will then perform the action that follows the text block
        // it will then navigate to the next text block which follows, or will return to the town menu
        public string SceneName { get; set; }

        public List<TextBlockModel> TextBlocks { get; set; }

        public string currentEvent { get; set; }
    }
}
