using NUnit.Framework;
using BarterBound.Controllers;
using Moq;
using BarterBound.Shared;

namespace BarterBound.Tests.Controllers
{
    public class GameControllerTests
    {
        private GameController gameController;

        private MenuController menuController;


        [SetUp]
        public void Setup()
        {
            gameController = new GameController();
        }

    }
}