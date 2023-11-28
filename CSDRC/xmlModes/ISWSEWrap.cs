using System.Xml.Serialization;
[XmlRoot("ISWSEWrap")]
public class ISWSEWrap
{
     [XmlAttribute("Action_")]
     public string Action_ {get;set;}
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
}
