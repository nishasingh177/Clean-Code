using System;
using System.Collections.Generic;

namespace TemplateEngine
{
    public class TemplateEngine
    {
        private string _template;
        private Dictionary<string, string> _variables = new Dictionary<string, string>();

        public void setTemplate(string template)
        {
            _template = template;
        }

        public void setVariable(string key, string value)
        {
            _variables[key] = value;
        }

        public string Evaluate()
        {
            string result = _template;
            foreach (var variable in _variables)
            {
                result = result.Replace($"{{{variable.Key}}}", variable.Value);
            }
            return result;
        }
    }
}
