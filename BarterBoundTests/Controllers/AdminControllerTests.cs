using NUnit.Framework;
using BarterBound.Controllers;
using Moq;
using BarterBound.Services.Interfaces;
using BarterBound.Tests.Controllers.ServicesTestable;
using BarterBound.Controllers.Admin;

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
            

            var adminController = new AdminController(_fileService, _console);

            adminController.Run();
        }
    }
}
