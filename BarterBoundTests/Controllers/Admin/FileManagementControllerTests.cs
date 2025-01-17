using BarterBound.Admin.AddScene;
using BarterBound.Models;
using BarterBound.Tests.Controllers.ServicesTestable;
using NUnit.Framework;

namespace BarterBound.Tests.Controllers.Admin;

[TestFixture]
internal class FileManagementControllerTests
{
    [Test]
    public void TestFileExists_ReturnsFalse_WhenFileDoesntExist()
    {
        var fileWrapper = new FileTestable();

        var fileManagementController = new FileManagementController(fileWrapper);

        var sceneName = "SceneDoesntExist";

        Assert.That(fileManagementController.FileExists(sceneName), Is.False, "");
    }
    [Test]
    public void TestFileExists_ReturnsTrue_WhenFileExists()
    {
        var fileWrapper = new FileTestable();

        var fileManagementController = new FileManagementController(fileWrapper);

        var sceneName = "SceneExists";
        var sceneBlock = new Scene();

        fileManagementController.WriteFile(sceneName, sceneBlock);


        Assert.That(fileManagementController.FileExists(sceneName), Is.True, "");

    }
}
