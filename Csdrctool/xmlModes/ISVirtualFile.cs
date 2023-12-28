using System.Xml.Serialization;
[XmlRoot("ISVirtualFile")]
public class ISVirtualFile
{
     [XmlAttribute("File_")]
     public string File_ {get;set;}
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
}
