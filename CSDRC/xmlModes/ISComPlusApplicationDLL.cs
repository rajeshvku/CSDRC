using System.Xml.Serialization;
[XmlRoot("ISComPlusApplicationDLL")]
public class ISComPlusApplicationDLL
{
     [XmlAttribute("ISComPlusApplicationDLL")]
     public string ISComPlusApplicationDLLs {get;set;}
     [XmlAttribute("ISComPlusApplication_")]
     public string ISComPlusApplication_ {get;set;}
     [XmlAttribute("ISComCatalogObject_")]
     public string ISComCatalogObject_ {get;set;}
     [XmlAttribute("CLSID")]
     public string CLSID {get;set;}
     [XmlAttribute("ProgId")]
     public string ProgId {get;set;}
     [XmlAttribute("DLL")]
     public string DLL {get;set;}
     [XmlAttribute("AlterDLL")]
     public string AlterDLL {get;set;}
}
