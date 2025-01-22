using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarterBound.Admin.Builders;
using BarterBound.Data.Enums;

namespace BarterBound.Tests.Controllers.Admin.Builders;

internal class TextBlockBuilderTests
{
    [Test]
    public void CheckValidEvent_OnValidEvent_ExpectTrue()
    {
        var textBlockBuilder = new TextBlockBuilder();

        var validEventString = "OnStart";

        Assert.That(textBlockBuilder.CheckValidEvent(validEventString), Is.True);
    }

    [Test]
    public void CheckValidEvent_OnInvalidEvent_ExpectFalse()
    {
        var textBlockBuilder = new TextBlockBuilder();

        var invalidEventString = "Invalid";

        Assert.That(textBlockBuilder.CheckValidEvent(invalidEventString), Is.False);
    }

    [Test]
    public void AddTriggerEvent_OnAddEvent_ExpectEventAdded()
    {
        var textBlockBuilder = new TextBlockBuilder();

        var validEnum = Event.OnStart;

        textBlockBuilder.AddTriggerEvent(validEnum);

        Assert.That(textBlockBuilder.GetTriggerEvent() == validEnum);
    }
}
