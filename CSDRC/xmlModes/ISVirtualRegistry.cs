using System.Xml.Serialization;
[XmlRoot("ISVirtualRegistry")]
public class ISVirtualRegistry
{
     [XmlAttribute("Registry_")]
     public string Registry_ {get;set;}
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
}
