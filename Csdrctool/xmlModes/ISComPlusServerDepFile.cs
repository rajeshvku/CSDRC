using System.Xml.Serialization;
[XmlRoot("ISComPlusServerDepFile")]
public class ISComPlusServerDepFile
{
     [XmlAttribute("ISComPlusApplication_")]
     public string ISComPlusApplication_ {get;set;}
     [XmlAttribute("File_")]
     public string File_ {get;set;}
     [XmlAttribute("ISPath")]
     public string ISPath {get;set;}
}
