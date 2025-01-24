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

    [Test]
    public void GetUserInputUntilValid_OnIncorrectInput_ExpectPromptAgain()
    {
        var console = new ConsoleTestable();
        var userInputService = new UserInputService(console);
        var invalidInput = "Invalid Input";
        var prompt = "Please enter an integer";
        var incorrectWarning = "Please enter the correct input type.";
        Type type = typeof(int);

        console.SetReadLine(invalidInput);

        userInputService.GetUserInputUntilValid(type, prompt, incorrectWarning);

        Assert.That(console.GetLastWrittenLine() == incorrectWarning);
    }
}
