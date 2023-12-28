using System.Xml.Serialization;
[XmlRoot("MsiDriverPackages")]
public class MsiDriverPackages
{
     [XmlAttribute("Component")]
     public string Component {get;set;}
     [XmlAttribute("Flags")]
     public string Flags {get;set;}
     [XmlAttribute("Sequence")]
     public string Sequence {get;set;}
     [XmlAttribute("ReferenceComponents")]
     public string ReferenceComponents {get;set;}
}
