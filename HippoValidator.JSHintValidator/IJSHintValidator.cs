namespace HippoValidator.JsHintValidator
{
    public interface IJsHintValidator
    {
        ValidationResult Validate(string script, Options options);
    }
}