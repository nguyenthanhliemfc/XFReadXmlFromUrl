using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CurrencyVietCbank.Models
{
    public class Exrate
    {
        [XmlAttribute(AttributeName = "CurrencyCode")] //Mean Maping Attribute in C# with XML from url
        public string CurrencyCode { get; set; }
        [XmlAttribute(AttributeName = "CurrencyName")]
        public string CurrencyName { get; set; }
        [XmlAttribute(AttributeName = "Buy")]
        public string Buy { get; set; }
        [XmlAttribute(AttributeName = "Transfer")]
        public string Transfer { get; set; }
        [XmlAttribute(AttributeName = "Sell")]
        public string Sell { get; set; }
    }
}
