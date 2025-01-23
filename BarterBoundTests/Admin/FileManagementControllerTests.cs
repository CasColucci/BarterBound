using BarterBound.Admin.AddScene;
using BarterBound.Models;
using BarterBound.Tests.Controllers.ServicesTestable;
using NUnit.Framework;

namespace BarterBound.Tests.Admin;

[TestFixture]
internal class FileManagementControllerTests
{
    [Test]
    public void FileExists_WhenFileDoesntExist_ExpectFalse()
    {
        var serializer = new XmlSerializerTestable();
        var fileManagementController = new FileManagementController(serializer);

        var sceneName = "SceneDoesntExist.xml";

        Assert.That(fileManagementController.FileExists(sceneName), Is.False, "Scene doesn't exist and therefore should return false when checked");
    }

    [Test]
    public void FileExists_WhenFileExists_ExpectTrue()
    {
        var serializer = new XmlSerializerTestable();
        var fileManagementController = new FileManagementController(serializer);

        var sceneName = "SceneExists.xml";

        Assert.That(fileManagementController.FileExists(sceneName), Is.True, "Scene does exist and therefore should return true when checked");
    }


}
