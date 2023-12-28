using System.Xml.Serialization;
[XmlRoot("Environment")]
public class Environment
{
     [XmlAttribute("Environment")]
     public string Environments {get;set;}
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
}
