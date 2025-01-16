using NUnit.Framework;
using BarterBound.Data.Scenes;
using BarterBound.Data.Enums;
using Moq;

namespace BarterBoundTests
{
    public class SceneTests
    {
        // what can the scene class do?
        // the scene class can run the text that it is given
        // it can access the menu object to show options to the player
        // it can get the players current status and information
        // it can get the current locations name
        // they get the text scene from the file


        //[Test]
        //public void DisplayTextBlocks_WhenCalledWithTestFile_SetsCurrentEventToNextEvent()
        //{
        //    var scene = new SceneTestWithFile();
        //    var expected = NextActionEnum.None;

        //    scene.Run();

        //    Assert.That(scene.CurrentEvent, Is.EqualTo(expected));
        //}
    }

    public class SceneTestNoFile : Scene
    {
        public override string SceneName => "NotRealFile";
    }

    public class SceneTestWithFile : Scene
    {
        public override string SceneName => "Test";
    }
}
