using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Jurassic;

namespace HippoValidator.JsHintValidator
{
    public class JsHintValidator : IJsHintValidator
    {
        readonly ScriptEngine _scriptEngine;

        public JsHintValidator()
        {
            _scriptEngine = new ScriptEngine();
            var jsHintScript = typeof(JsHintValidator).Assembly.GetManifestResourceStream("HippoValidator.JsHintValidator.jshint.js");
            Debug.Assert(jsHintScript != null, "jsHintScript != null");
            using (var reader = new StreamReader(jsHintScript))
            {
                _scriptEngine.Execute(reader.ReadToEnd());
            }
        }

        public ValidationResult Validate(string script, Options options)
        {
            if (options == null) options = new Options();
            var result = new ValidationResult();

            _scriptEngine.Execute("var result = JSHINT('" + script + "', " + options.ToJson() + "), errors = JSHINT.errors;");
            var errors = ((Jurassic.Library.ArrayInstance) _scriptEngine.GetGlobalValue("errors"))
                .ElementValues
                .OfType<Jurassic.Library.ObjectInstance>();

            foreach (var error in errors.Where(error => error != null))
            {
                result.Errors.Add(new Error
                    {
                        Character = Get(error, "character", 0),
                        Line = Get(error, "line", 0),
                        Reason = Get(error, "reason", string.Empty),
                        Evidence = Get(error, "evidence", string.Empty),
                        Raw = Get(error, "raw", string.Empty),
                    });
            }

            return result;
        }

        private static T Get<T>(Jurassic.Library.ObjectInstance dic, string name, T defaultValue)
        {
            var value = dic.GetPropertyValue(name);
            T ret = defaultValue;
            try
            {
                if (defaultValue is string) ret = (T)(object)Convert.ToString(value);
                else ret = (T)Convert.ChangeType(value, typeof(T));
            }
            catch { }
            return ret;
        }
   }
}