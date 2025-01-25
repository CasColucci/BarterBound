using BarterBound.Shared;
using BarterBound.Tests.Core;


namespace BarterBound.Tests.Shared;

internal class UserInputServiceTests
{
    [Test]
    public void GetUserInput_OnAddValidInput_ExpectInputReturned()
    {
        var console = new ConsoleTestable();
        var userInputService = new UserInputService(console);
        var validInput = "Test Input";

        console.SetReadLine(validInput);

        Assert.That(userInputService.GetUserInput() == validInput);
    }
}
