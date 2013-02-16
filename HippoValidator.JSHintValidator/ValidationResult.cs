using System.Collections.Generic;

namespace HippoValidator.JsHintValidator
{
    public class ValidationResult
    {
        public ValidationResult()
        {
            Errors = new List<Error>();
        }

        public List<Error> Errors { get; set; }
    }
}