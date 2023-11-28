using System.Xml.Serialization;
[XmlRoot("Property")]
public class Property
{
     [XmlAttribute("Property")]
     public string Propertys {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
     [XmlAttribute("ISComments")]
     public string ISComments {get;set;}
}
