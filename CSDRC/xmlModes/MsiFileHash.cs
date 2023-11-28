using System.Xml.Serialization;
[XmlRoot("MsiFileHash")]
public class MsiFileHash
{
     [XmlAttribute("File_")]
     public string File_ {get;set;}
     [XmlAttribute("Options")]
     public string Options {get;set;}
     [XmlAttribute("HashPart1")]
     public string HashPart1 {get;set;}
     [XmlAttribute("HashPart2")]
     public string HashPart2 {get;set;}
     [XmlAttribute("HashPart3")]
     public string HashPart3 {get;set;}
     [XmlAttribute("HashPart4")]
     public string HashPart4 {get;set;}
}
