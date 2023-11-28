using System.Xml.Serialization;
[XmlRoot("Signature")]
public class Signature
{
     [XmlAttribute("Signature")]
     public string Signatures {get;set;}
     [XmlAttribute("FileName")]
     public string FileName {get;set;}
     [XmlAttribute("MinVersion")]
     public string MinVersion {get;set;}
     [XmlAttribute("MaxVersion")]
     public string MaxVersion {get;set;}
     [XmlAttribute("MinSize")]
     public string MinSize {get;set;}
     [XmlAttribute("MaxSize")]
     public string MaxSize {get;set;}
     [XmlAttribute("MinDate")]
     public string MinDate {get;set;}
     [XmlAttribute("MaxDate")]
     public string MaxDate {get;set;}
     [XmlAttribute("Languages")]
     public string Languages {get;set;}
}
