using System.Xml.Serialization;
[XmlRoot("ISStorages")]
public class ISStorages
{
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("ISBuildSourcePath")]
     public string ISBuildSourcePath {get;set;}
}
