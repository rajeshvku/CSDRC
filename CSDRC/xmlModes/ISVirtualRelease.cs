using System.Xml.Serialization;
[XmlRoot("ISVirtualRelease")]
public class ISVirtualRelease
{
     [XmlAttribute("ISRelease_")]
     public string ISRelease_ {get;set;}
     [XmlAttribute("ISProductConfiguration_")]
     public string ISProductConfiguration_ {get;set;}
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
}
