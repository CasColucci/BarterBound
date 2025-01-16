using NUnit.Framework;
using BarterBound.Controllers;
using Moq;
using BarterBound.Services.Interfaces;
using BarterBound.Tests.Controllers.ServicesTestable;

namespace BarterBound.Tests.Controllers
{


    public class AdminControllerTests
    {
        [Test]
        public void Run_ExpectWhenCalled_SceneBlockIsMade()
        {
            var _fileService = new FileServiceTestable();
            var _console = new ConsoleServiceTestable();

            var adminController = new AdminController(_fileService, _console);

            adminController.Run();
        }
    }
}
