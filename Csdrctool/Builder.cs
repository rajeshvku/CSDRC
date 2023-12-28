using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csdrctool
{
    public class Builder
    {
        public string WixBuilder()
        {
            return string.Empty;
        }
        public string GetProduct()
        {
            var startingElement = "<Product Id=\"3E786878-358D-43AD-82D1-1435ADF9F6EA\"\r\nName=\"Awesome Software\"\r\nLanguage=\"1033\"\r\nVersion=\"1.0.0.0\"\r\nManufacturer=\"Awesome Company\"\r\nUpgradeCode=\"B414C827-8D81-4B4A-B3B6-338C06DE3A11\">";
            var endingElement = "</Product>";
            return string.Empty;
        }

    }
    public class WixProperties
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
