using System;
using NUnit.Framework;

namespace HippoValidator.JsHintValidator.Tests
{
    public class JsHintValidatorTest
    {
        [Test]
        public void CanValidateValidScript()
        {
            // Arrange
            var script = "var answer = 42;";
            var validator = new JsHintValidator();

            // Act
            var result = validator.Validate(script, new Options());

            // Assert
            Assert.That(result.Errors.Count, Is.EqualTo(0));
        }

        [Test]
        public void CanFindErrorInScript()
        {
            // Arrange
            var script = "var answer = 42 == 42;";
            var validator = new JsHintValidator();

            // Act
            var result = validator.Validate(script, new Options {Eqeqeq = true});

            // Assert
            Assert.That(result.Errors.Count, Is.EqualTo(1));
        }

        [Test]
        public void CanValidateScriptWithNewLine()
        {
            // Arrange
            var validator = new JsHintValidator();

            // Act
            var result = validator.Validate(@"
                $(document).ready(function () {
                });
            ", new Options());

            // Assert
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void CanValidateScriptWithSingleQuote()
        {
            // Arrange
            var validator = new JsHintValidator();

            // Act
            var result = validator.Validate("$('.test');", new Options());

            // Assert
            Assert.That(result, Is.Not.Null);
        }
    }
}