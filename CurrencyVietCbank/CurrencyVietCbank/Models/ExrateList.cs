using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CurrencyVietCbank.Models
{
    [XmlRoot(ElementName = "ExrateList")]
    public class ExrateList
    {
        [XmlElement(ElementName = "DateTime")] //Mean Maping Attribute in C# with XML from url
        public string DateTime { get; set; }
        [XmlElement(ElementName = "Exrate")]
        public List<Exrate> Exrates { get; set; }
        [XmlElement(ElementName = "Source")]
        public string Source { get; set; }
    }
}
