using System.Xml.Serialization;
[XmlRoot("ISCustomActionReference")]
public class ISCustomActionReference
{
     [XmlAttribute("Action_")]
     public string Action_ {get;set;}
     [XmlAttribute("Description")]
     public string Description {get;set;}
     [XmlAttribute("FileType")]
     public string FileType {get;set;}
     [XmlAttribute("ISCAReferenceFilePath")]
     public string ISCAReferenceFilePath {get;set;}
}
