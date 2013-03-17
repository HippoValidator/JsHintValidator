﻿using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Jurassic;
using Jurassic.Library;

namespace HippoValidator.JsHintValidator
{
    public class JsHintValidator : IJsHintValidator
    {
        readonly ScriptEngine _scriptEngine;

        public JsHintValidator()
        {
            _scriptEngine = new ScriptEngine();
            _scriptEngine.CompatibilityMode = CompatibilityMode.ECMAScript3;
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

            var fix = script
                .Replace("'", "\\'")
                .Replace(Environment.NewLine, string.Empty)
                .Trim();

            _scriptEngine.Execute("var result = JSHINT('" + fix + "', " + options.ToJS() + "), errors = JSHINT.errors;");
            var errors = ((ArrayInstance) _scriptEngine.GetGlobalValue("errors"))
                .ElementValues
                .OfType<ObjectInstance>();

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

            foreach (var error in result.Errors.Where(x => !string.IsNullOrWhiteSpace(x.Evidence)))
            {
                var startIndex = error.Character < 10 ? 0 : error.Character - 10;
                var count = (error.Evidence.Length - startIndex) >= 20 ? 20 : error.Evidence.Length - startIndex;
                error.Source = error.Evidence.Substring(startIndex, count);
            }

            return result;
        }

        private static T Get<T>(ObjectInstance dictionary, string name, T defaultValue)
        {
            var value = dictionary.GetPropertyValue(name);
            var toReturn = defaultValue;
            try
            {
                if (defaultValue is string)
                {
                    toReturn = (T) (object) Convert.ToString(value);
                }
                else
                {
                    toReturn = (T) Convert.ChangeType(value, typeof (T));
                }
            }
            catch {}

            return toReturn;
        }
   }
}