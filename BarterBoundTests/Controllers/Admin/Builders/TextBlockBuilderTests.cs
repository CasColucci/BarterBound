using BarterBound.Admin.Builders;
using BarterBound.Data.Enums;

namespace BarterBound.Tests.Controllers.Admin.Builders;

internal class TextBlockBuilderTests
{
    private TextBlockBuilder _builder;

    [SetUp]
    public void SetUp()
    {
        _builder = new TextBlockBuilder();
    }

    [Test]
    public void SetTriggerEvent_OnAddEvent_ExpectEventAdded()
    {
        var validEnum = Event.OnStart;

        _builder.SetTriggerEvent(validEnum);

        Assert.That(_builder.GetTriggerEvent() == validEnum);
    }

    [Test]
    public void SetTextValues_OnAddTextValues_ExpectTextValuesAdded()
    {
        var textValues = new List<string>()
        {
            "Test 1",
            "Test 2",
            "Test 3"
        };

        _builder.SetTextValues(textValues);

        Assert.That(_builder.GetTextValues() == textValues);
    }

    [Test]
    public void SetNextEvent_OnAddEvent_ExpectEventAdded()
    {
        var validEnum = Event.None;

        _builder.SetNextEvent(validEnum);

        Assert.That(_builder.GetNextEvent() == validEnum);
    }
}
