using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalValidationTool.TestAutomation.Helper
{
    public static class GetDataAsJsonObject
    {
        public static JObject DataReaderJobject(object value, string node)
        {
            JObject obj = JObject.Parse(value.ToString());
            var t = obj[node].ToObject<List<dynamic>>()[0];
            return t;
        }

    }
}
