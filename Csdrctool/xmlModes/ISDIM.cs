using System.Xml.Serialization;
[XmlRoot("ISDIM")]
public class ISDIM
{
     [XmlAttribute("DIM")]
     public string DIM {get;set;}
     [XmlAttribute("ISBuildSourcePath")]
     public string ISBuildSourcePath {get;set;}
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("Destination")]
     public string Destination {get;set;}
     [XmlAttribute("ISAttributes")]
     public string ISAttributes {get;set;}
}
