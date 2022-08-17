using System;
using NUnit.Framework;
using TestNinja.Fundamentals;
using Assert = NUnit.Framework.Assert;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HTMLFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");

            //Specific
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);

            //More general
            //Assert.That(result, Does.StartWith("<string>"));
            //Assert.That(result, Does.EndWith("</string>").IgnoreCase);
            //Assert.That(result, Does.Contain("abc"));
        }
    }
}

