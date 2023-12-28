using System.Xml.Serialization;
[XmlRoot("ISComCatalogObject")]
public class ISComCatalogObject
{
     [XmlAttribute("ISComCatalogObject")]
     public string ISComCatalogObjects {get;set;}
     [XmlAttribute("DisplayName")]
     public string DisplayName {get;set;}
}
