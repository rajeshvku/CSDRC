using System.Xml.Serialization;
[XmlRoot("ISPathVariable")]
public class ISPathVariable
{
     [XmlAttribute("ISPathVariable")]
     public string ISPathVariables {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
     [XmlAttribute("TestValue")]
     public string TestValue {get;set;}
     [XmlAttribute("Type")]
     public string Type {get;set;}
}
