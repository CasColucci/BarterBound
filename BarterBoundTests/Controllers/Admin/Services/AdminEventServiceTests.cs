using BarterBound.Admin.Services;
using BarterBound.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarterBound.Tests.Controllers.Admin.Services;

internal class AdminEventServiceTests
{
    private AdminEventService _service;

    [SetUp]
    public void SetUp()
    {
        _service = new AdminEventService();
    }

    [Test]
    public void CheckValidEvent_OnValidEvent_ExpectTrue()
    {
        var validEventString = "OnStart";

        Assert.That(_service.CheckValidEvent(validEventString), Is.True);
    }

    [Test]
    public void CheckValidEvent_OnInvalidEvent_ExpectFalse()
    {
        var invalidEventString = "Invalid";

        Assert.That(_service.CheckValidEvent(invalidEventString), Is.False);
    }

    [Test]
    public void CheckValidEvent_OnBadEvent_ExpectFalse()
    {
        var badEventString = "Garbage Event String";

        Assert.That(_service.CheckValidEvent(badEventString), Is.False);
    }

    [Test]
    public void ConvertStringToEvent_OnValidEvent_ExpectSuccessfulChange()
    {
        var validEventString = "OnStart";
        var onStart = Event.OnStart;

        Event returnedEvent = _service.ConvertStringToEvent(validEventString);

        Assert.That(returnedEvent, Is.EqualTo(onStart));
    }

    [Test]
    public void ConvertStringToEvent_OnInvalidEvent_ExpectError()
    {
        var invalidEventString = "Invalid";

        Assert.Throws<ArgumentException>(() => _service.ConvertStringToEvent(invalidEventString));
    }

    [Test]
    public void ConvertStringToEvent_OnBadEvent_ExpectError()
    {
        var badEventString = "Garbage Event String";

        Assert.Throws<ArgumentException>(() => _service.ConvertStringToEvent(badEventString));

    }
}
