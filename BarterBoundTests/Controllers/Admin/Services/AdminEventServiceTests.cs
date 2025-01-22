using BarterBound.Admin.Services;
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
}
