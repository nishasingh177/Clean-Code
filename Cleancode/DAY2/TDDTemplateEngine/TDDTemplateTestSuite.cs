using NUnit.Framework;
using System;

namespace TemplateEngine.Tests
{
    public class TemplateEngineTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldEvaluateForSingleVariable()
        {
            TemplateEngine templateEngine = new TemplateEngine();
            templateEngine.setTemplate("Hello {name}");
            templateEngine.setVariable("name", "Nisha");
            string result = templateEngine.Evaluate();
            Assert.That(result, Is.EqualTo("Hello Nisha"));
        }
    }
}
