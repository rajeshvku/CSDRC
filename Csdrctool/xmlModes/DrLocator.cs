using System.Xml.Serialization;
[XmlRoot("DrLocator")]
public class DrLocator
{
     [XmlAttribute("Signature_")]
     public string Signature_ {get;set;}
     [XmlAttribute("Parent")]
     public string Parent {get;set;}
     [XmlAttribute("Path")]
     public string Path {get;set;}
     [XmlAttribute("Depth")]
     public string Depth {get;set;}
}
