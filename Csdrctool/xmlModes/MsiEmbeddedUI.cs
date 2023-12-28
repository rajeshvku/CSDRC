using System.Xml.Serialization;
[XmlRoot("MsiEmbeddedUI")]
public class MsiEmbeddedUI
{
     [XmlAttribute("MsiEmbeddedUI")]
     public string MsiEmbeddedUIs {get;set;}
     [XmlAttribute("FileName")]
     public string FileName {get;set;}
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
     [XmlAttribute("MessageFilter")]
     public string MessageFilter {get;set;}
     [XmlAttribute("Data")]
     public string Data {get;set;}
     [XmlAttribute("ISBuildSourcePath")]
     public string ISBuildSourcePath {get;set;}
}
