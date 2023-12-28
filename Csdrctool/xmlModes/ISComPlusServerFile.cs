using System.Xml.Serialization;
[XmlRoot("ISComPlusServerFile")]
public class ISComPlusServerFile
{
     [XmlAttribute("File_")]
     public string File_ {get;set;}
     [XmlAttribute("ISComPlusApplicationDLL_")]
     public string ISComPlusApplicationDLL_ {get;set;}
}
