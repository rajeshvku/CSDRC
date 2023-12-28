using System.Xml.Serialization;
[XmlRoot("MsiEmbeddedChainer")]
public class MsiEmbeddedChainer
{
     [XmlAttribute("MsiEmbeddedChainer")]
     public string MsiEmbeddedChainers {get;set;}
     [XmlAttribute("Condition")]
     public string Condition {get;set;}
     [XmlAttribute("CommandLine")]
     public string CommandLine {get;set;}
     [XmlAttribute("Source")]
     public string Source {get;set;}
     [XmlAttribute("Type")]
     public string Type {get;set;}
}
