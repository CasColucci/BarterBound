using NUnit.Framework;
using BarterBound.Controllers;
using Moq;
using BarterBound.Tests.Controllers.ServicesTestable;
using BarterBound.Admin.AddScene;

namespace BarterBound.Tests.Controllers
{


    public class AdminControllerTests
    {
        [Test]
        public void GetFileName_WhenFileAlreadyExists_ExpectThisFileNameAlreadyExists()
        {
            var _fileService = new FileTestable();
            var _console = new ConsoleTestable();
            _console.ToRead = "Exists";
            

            var adminController = new AddSceneController(_console);

            adminController.Run();
        }
    }
}
