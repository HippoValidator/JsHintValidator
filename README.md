JsHintValidator
===============

Executes JSHint from .NET.

How to use it? Best illustrated through a test:

```csharp
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
```
