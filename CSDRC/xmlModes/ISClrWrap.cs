using System.Xml.Serialization;
[XmlRoot("ISClrWrap")]
public class ISClrWrap
{
     [XmlAttribute("Action_")]
     public string Action_ {get;set;}
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
}
