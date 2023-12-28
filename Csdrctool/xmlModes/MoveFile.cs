using System.Xml.Serialization;
[XmlRoot("MoveFile")]
public class MoveFile
{
     [XmlAttribute("FileKey")]
     public string FileKey {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("SourceName")]
     public string SourceName {get;set;}
     [XmlAttribute("DestName")]
     public string DestName {get;set;}
     [XmlAttribute("SourceFolder")]
     public string SourceFolder {get;set;}
     [XmlAttribute("DestFolder")]
     public string DestFolder {get;set;}
     [XmlAttribute("Options")]
     public string Options {get;set;}
}
