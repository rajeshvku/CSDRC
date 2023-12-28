using System.Xml.Serialization;
[XmlRoot("ISComPlusProxyDepFile")]
public class ISComPlusProxyDepFile
{
     [XmlAttribute("ISComPlusApplication_")]
     public string ISComPlusApplication_ {get;set;}
     [XmlAttribute("File_")]
     public string File_ {get;set;}
     [XmlAttribute("ISPath")]
     public string ISPath {get;set;}
}
