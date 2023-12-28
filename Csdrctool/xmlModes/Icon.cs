using System.Xml.Serialization;
[XmlRoot("Icon")]
public class Icon
{
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("Data")]
     public string Data {get;set;}
     [XmlAttribute("ISBuildSourcePath")]
     public string ISBuildSourcePath {get;set;}
     [XmlAttribute("ISIconIndex")]
     public string ISIconIndex {get;set;}
}
