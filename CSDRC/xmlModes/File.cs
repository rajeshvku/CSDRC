using System.Xml.Serialization;
[XmlRoot("File")]
public class File
{
     [XmlAttribute("File")]
     public string Files {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("FileName")]
     public string FileName {get;set;}
     [XmlAttribute("FileSize")]
     public string FileSize {get;set;}
     [XmlAttribute("Version")]
     public string Version {get;set;}
     [XmlAttribute("Language")]
     public string Language {get;set;}
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
     [XmlAttribute("Sequence")]
     public string Sequence {get;set;}
     [XmlAttribute("ISBuildSourcePath")]
     public string ISBuildSourcePath {get;set;}
     [XmlAttribute("ISAttributes")]
     public string ISAttributes {get;set;}
     [XmlAttribute("ISComponentSubFolder_")]
     public string ISComponentSubFolder_ {get;set;}
}
