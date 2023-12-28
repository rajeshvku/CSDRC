using System.Xml.Serialization;
[XmlRoot("DuplicateFile")]
public class DuplicateFile
{
     [XmlAttribute("FileKey")]
     public string FileKey {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("File_")]
     public string File_ {get;set;}
     [XmlAttribute("DestName")]
     public string DestName {get;set;}
     [XmlAttribute("DestFolder")]
     public string DestFolder {get;set;}
}
