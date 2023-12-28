using System.Xml.Serialization;
[XmlRoot("ISDisk1File")]
public class ISDisk1File
{
     [XmlAttribute("ISDisk1File")]
     public string ISDisk1Files {get;set;}
     [XmlAttribute("ISBuildSourcePath")]
     public string ISBuildSourcePath {get;set;}
     [XmlAttribute("Disk")]
     public string Disk {get;set;}
}
