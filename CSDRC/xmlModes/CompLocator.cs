using System.Xml.Serialization;
[XmlRoot("CompLocator")]
public class CompLocator
{
     [XmlAttribute("Signature_")]
     public string Signature_ {get;set;}
     [XmlAttribute("ComponentId")]
     public string ComponentId {get;set;}
     [XmlAttribute("Type")]
     public string Type {get;set;}
}
