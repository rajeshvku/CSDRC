using System.Xml.Serialization;
[XmlRoot("ISComPlusProxyFile")]
public class ISComPlusProxyFile
{
     [XmlAttribute("File_")]
     public string File_ {get;set;}
     [XmlAttribute("ISComPlusApplicationDLL_")]
     public string ISComPlusApplicationDLL_ {get;set;}
}
