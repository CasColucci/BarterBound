using BarterBound.Admin.AddScene;
using BarterBound.Tests.Controllers.ServicesTestable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarterBound.Tests.Controllers.Admin
{
    internal class FileManagementControllerTests
    {
        [Test]
        public void TestFileExists_ReturnsTrue_WhenFileExists()
        {
            var fileWrapper = new FileTestable();

            var fileManagementController = new FileManagementController(fileWrapper);
        }
    }
}
