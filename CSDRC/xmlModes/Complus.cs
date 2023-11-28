using System.Xml.Serialization;
[XmlRoot("Complus")]
public class Complus
{
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("ExpType")]
     public string ExpType {get;set;}
}
