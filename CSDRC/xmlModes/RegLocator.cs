using System.Xml.Serialization;
[XmlRoot("RegLocator")]
public class RegLocator
{
     [XmlAttribute("Signature_")]
     public string Signature_ {get;set;}
     [XmlAttribute("Root")]
     public string Root {get;set;}
     [XmlAttribute("Key")]
     public string Key {get;set;}
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("Type")]
     public string Type {get;set;}
}
