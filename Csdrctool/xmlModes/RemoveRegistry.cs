using System.Xml.Serialization;
[XmlRoot("RemoveRegistry")]
public class RemoveRegistry
{
     [XmlAttribute("RemoveRegistry")]
     public string RemoveRegistrys {get;set;}
     [XmlAttribute("Root")]
     public string Root {get;set;}
     [XmlAttribute("Key")]
     public string Key {get;set;}
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
}
