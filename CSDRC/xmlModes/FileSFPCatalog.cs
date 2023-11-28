using System.Xml.Serialization;
[XmlRoot("FileSFPCatalog")]
public class FileSFPCatalog
{
     [XmlAttribute("File_")]
     public string File_ {get;set;}
     [XmlAttribute("SFPCatalog_")]
     public string SFPCatalog_ {get;set;}
}
