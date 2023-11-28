using System.Xml.Serialization;
[XmlRoot("ISVirtualDirectory")]
public class ISVirtualDirectory
{
     [XmlAttribute("Directory_")]
     public string Directory_ {get;set;}
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
}
