using System.Xml.Serialization;
[XmlRoot("ISComCatalogCollection")]
public class ISComCatalogCollection
{
     [XmlAttribute("ISComCatalogCollection")]
     public string ISComCatalogCollections {get;set;}
     [XmlAttribute("ISComCatalogObject_")]
     public string ISComCatalogObject_ {get;set;}
     [XmlAttribute("CollectionName")]
     public string CollectionName {get;set;}
}
