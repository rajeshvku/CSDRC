using System.Xml.Serialization;
[XmlRoot("SFPCatalog")]
public class SFPCatalog
{
     [XmlAttribute("SFPCatalog")]
     public string SFPCatalogs {get;set;}
     [XmlAttribute("Catalog")]
     public string Catalog {get;set;}
     [XmlAttribute("Dependency")]
     public string Dependency {get;set;}
}
