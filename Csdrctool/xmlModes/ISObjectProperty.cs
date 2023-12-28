using System.Xml.Serialization;
[XmlRoot("ISObjectProperty")]
public class ISObjectProperty
{
     [XmlAttribute("ObjectName")]
     public string ObjectName {get;set;}
     [XmlAttribute("Property")]
     public string Property {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
     [XmlAttribute("IncludeInBuild")]
     public string IncludeInBuild {get;set;}
}
