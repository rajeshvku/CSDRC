using System.Xml.Serialization;
[XmlRoot("ISVirtualPackage")]
public class ISVirtualPackage
{
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
}
