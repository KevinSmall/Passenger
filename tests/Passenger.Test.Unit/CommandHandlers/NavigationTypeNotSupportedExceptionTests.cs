﻿using Passenger.Attributes;
using Passenger.CommandHandlers;
using NUnit.Framework;

namespace Passenger.Test.Unit.CommandHandlers
{
    [TestFixture]
    public class NavigationTypeNotSupportedExceptionTests
    {
        [Test]
        public void Ctor_GeneratesHelpfulMessage()
        {
            var ex = new NavigationTypeNotSupportedException(new IdAttribute(), "myElement");

            Assert.That(ex.Message, Does.Contain("IdAttribute"));
            Assert.That(ex.Message, Does.Contain("myElement"));
        }
    }
}
