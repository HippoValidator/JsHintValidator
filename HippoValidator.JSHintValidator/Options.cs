using System.Text;

namespace HippoValidator.JsHintValidator
{
    public class Options
    {
        /// <summary>
        /// If automatic semicolon insertion should be tolerated.
        /// </summary>
        public bool Asi { get; set; }

        /// <summary>
        /// If bitwise operators should not be allowed.
        /// </summary>
        public bool Bitwise { get; set; }

        /// <summary>
        /// If advanced usage of assignments should be allowed.
        /// </summary>
        public bool Boss { get; set; }

        /// <summary>
        /// If the standard browser globals should be predefined.
        /// </summary>
        public bool Browser { get; set; }

        /// <summary>
        /// If identifiers should be required in camel case.
        /// </summary>
        public bool Camelcase { get; set; }

        /// <summary>
        /// If CouchDB globals should be predefined.
        /// </summary>
        public bool Couch { get; set; }

        /// <summary>
        /// If curly braces around all blocks should be required.
        /// </summary>
        public bool Curly { get; set; }

        /// <summary>
        /// If debugger statements should be allowed.
        /// </summary>
        public bool Debug { get; set; }

        /// <summary>
        /// If logging globals should be predefined (console, alert, etc.).
        /// </summary>
        public bool Devel { get; set; }

        /// <summary>
        /// If Dojo Toolkit globals should be predefined.
        /// </summary>
        public bool Dojo { get; set; }

        /// <summary>
        /// If === should be required.
        /// </summary>
        public bool Eqeqeq { get; set; }

        /// <summary>
        /// If == null comparisons should be tolerated.
        /// </summary>
        public bool Eqnull { get; set; }

        /// <summary>
        /// If ES5 syntax should be allowed.
        /// </summary>
        public bool Es5 { get; set; }

        /// <summary>
        /// If es.next specific syntax should be allowed.
        /// </summary>
        public bool Esnext { get; set; }

        /// <summary>
        /// If eval should be allowed.
        /// </summary>
        public bool Evil { get; set; }

        /// <summary>
        /// If ExpressionStatement should be allowed as Programs.
        /// </summary>
        public bool Expr { get; set; }

        /// <summary>
        /// If for in statements must filter.
        /// </summary>
        public bool Forin { get; set; }

        /// <summary>
        /// If only function scope should be used for scope tests.
        /// </summary>
        public bool Funcscope { get; set; }

        /// <summary>
        /// If global "use strict"; should be allowed (also enables 'strict').
        /// </summary>
        public bool Globalstrict { get; set; }

        /// <summary>
        /// If immediate invocations must be wrapped in parens.
        /// </summary>
        public bool Immed { get; set; }

        /// <summary>
        /// If the `__iterator__` property should be allowed.
        /// </summary>
        public bool Iterator { get; set; }

        /// <summary>
        /// If jQuery globals should be predefined.
        /// </summary>
        public bool Jquery { get; set; }

        /// <summary>
        /// If semicolons may be ommitted for the trailing statements inside of a one-line blocks.
        /// </summary>
        public bool Lastsemic { get; set; }

        /// <summary>
        /// If the use before definition should not be tolerated.
        /// </summary>
        public bool Latedef { get; set; }

        /// <summary>
        /// If line breaks should not be checked.
        /// </summary>
        public bool Laxbreak { get; set; }

        /// <summary>
        /// If line breaks should not be checked around commas.
        /// </summary>
        public bool Laxcomma { get; set; }

        /// <summary>
        /// If functions should be allowed to be defined within loops.
        /// </summary>
        public bool Loopfunc { get; set; }

        /// <summary>
        /// If MooTools globals should be predefined.
        /// </summary>
        public bool Mootools { get; set; }

        /// <summary>
        /// Allow multiline strings.
        /// </summary>
        public bool Multistr { get; set; }

        /// <summary>
        /// If constructor names must be capitalized.
        /// </summary>
        public bool Newcap { get; set; }

        /// <summary>
        /// If arguments.caller and arguments.callee should be disallowed.
        /// </summary>
        public bool Noarg { get; set; }

        /// <summary>
        /// If the Node.js environment globals should be predefined.
        /// </summary>
        public bool Node { get; set; }

        /// <summary>
        /// If empty blocks should be disallowed.
        /// </summary>
        public bool Noempty { get; set; }

        /// <summary>
        /// If using `new` for side-effects should be disallowed.
        /// </summary>
        public bool Nonew { get; set; }

        /// <summary>
        /// If non-standard (but widely adopted) globals should be predefined.
        /// </summary>
        public bool Nonstandard { get; set; }

        /// <summary>
        /// If names should be checked.
        /// </summary>
        public bool Nomen { get; set; }

        /// <summary>
        /// If only one var statement per function should be allowed.
        /// </summary>
        public bool Onevar { get; set; }

        /// <summary>
        /// If one case switch statements should be allowed.
        /// </summary>
        public bool Onecase { get; set; }

        /// <summary>
        /// If the scan should stop on first error.
        /// </summary>
        public bool Passfail { get; set; }

        /// <summary>
        /// If increment/decrement should not be allowed.
        /// </summary>
        public bool Plusplus { get; set; }

        /// <summary>
        /// If the `__proto__` property should be allowed.
        /// </summary>
        public bool Proto { get; set; }

        //If Prototype and Scriptaculous globals should be predefined.
        public bool Prototypejs { get; set; }

        /// <summary>
        /// If unescaped first/last dash (-) inside brackets should be tolerated.
        /// </summary>
        public bool Regexdash { get; set; }

        /// <summary>
        /// If the . should not be allowed in regexp literals.
        /// </summary>
        public bool Regexp { get; set; }

        /// <summary>
        /// If the Rhino environment globals should be predefined.
        /// </summary>
        public bool Rhino { get; set; }

        /// <summary>
        /// If variables should be declared before used.
        /// </summary>
        public bool Undef { get; set; }

        /// <summary>
        /// If variables should be always used.
        /// </summary>
        public bool Unused { get; set; }

        /// <summary>
        /// If script-targeted URLs should be tolerated.
        /// </summary>
        public bool Scripturl { get; set; }

        /// <summary>
        /// If variable shadowing should be tolerated.
        /// </summary>
        public bool Shadow { get; set; }

        /// <summary>
        /// If smarttabs should be tolerated (http://www.emacswiki.org/emacs/SmartTabs).
        /// </summary>
        public bool Smarttabs { get; set; }

        /// <summary>
        /// require the "use strict"; pragma.
        /// </summary>
        public bool Strict { get; set; }

        /// <summary>
        /// If all forms of subscript notation are tolerated.
        /// </summary>
        public bool Sub { get; set; }

        /// <summary>
        /// If `new function () { ... };` and `new Object;` should be tolerated.
        /// </summary>
        public bool Supernew { get; set; }

        /// <summary>
        /// If trailing whitespace rules apply.
        /// </summary>
        public bool Trailing { get; set; }

        /// <summary>
        /// If 'this' inside a non-constructor function is valid. This is a function scoped option only.
        /// </summary>
        public bool Validthis { get; set; }

        /// <summary>
        /// If with statements should be allowed.
        /// </summary>
        public bool Withstmt { get; set; }

        /// <summary>
        /// If strict whitespace rules apply.
        /// </summary>
        public bool White { get; set; }

        /// <summary>
        /// If Web Worker script symbols should be allowed.
        /// </summary>
        public bool Worker { get; set; }

        /// <summary>
        /// If the Windows Scripting Host environment globals should be predefined.
        /// </summary>
        public bool Wsh { get; set; }

        /// <summary>
        /// YUI variables should be predefined.
        /// </summary>
        public bool Yui { get; set; }

        public string ToJson()
        {
            var sb = new StringBuilder();
            sb.Append("{");
            foreach (var property in GetType().GetProperties())
            {
                sb.Append(property.Name.ToLower()).Append(":").Append(property.GetValue(this, null).ToString().ToLower()).Append(",");
            }
            sb.Append("}");

            return sb.ToString().Replace(",}", "}");
        }
    }
}