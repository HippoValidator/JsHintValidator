namespace HippoValidator.JsHintValidator
{
    public class Error
    {
        public int Line { get; set; }

        public int Character { get; set; }

        public string Reason { get; set; }

        public string Evidence { get; set; }
        
        public string Source { get; set; }

        public string Raw { get; set; }
    }
}