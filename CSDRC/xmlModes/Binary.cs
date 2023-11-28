using System.Xml.Serialization;
[XmlRoot("Binary")]
public class Binary
{
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("Data")]
     public string Data {get;set;}
     [XmlAttribute("ISBuildSourcePath")]
     public string ISBuildSourcePath {get;set;}
}
