﻿using BarterBound.Admin.Builders;
using BarterBound.Admin.Services;
using BarterBound.Data.Enums;

namespace BarterBound.Tests.Controllers.Admin.Builders;

internal class TextBlockBuilderTests
{
    private TextBlockBuilder _builder;

    [SetUp]
    public void SetUp()
    {
        var adminEventService = new AdminEventService();
        _builder = new TextBlockBuilder(adminEventService);
    }

    [Test]
    public void SetTriggerEvent_OnAddValidEvent_ExpectEventAdded()
    {
        var validString = "OnStart";
        var validEvent = Event.OnStart;

        _builder.SetTriggerEvent(validString);

        Assert.That(_builder.GetTriggerEvent() == validEvent);
    }

    [Test]
    public void SetTriggerEvent_OnAddInvalidEvent_ExpectThrowError()
    {
        var invalidEnum = "Invalid";

        Assert.Throws<ArgumentException>(() => _builder.SetTriggerEvent(invalidEnum));
    }

    [Test]
    public void SetTriggerEvent_OnBadEvent_ExpectThrowError()
    {
        var invalidEnum = "Garbage String";

        Assert.Throws<ArgumentException>(() => _builder.SetTriggerEvent(invalidEnum));
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
