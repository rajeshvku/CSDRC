using System.Xml.Serialization;
[XmlRoot("ISComCatalogCollectionObjects")]
public class ISComCatalogCollectionObjects
{
     [XmlAttribute("ISComCatalogCollection_")]
     public string ISComCatalogCollection_ {get;set;}
     [XmlAttribute("ISComCatalogObject_")]
     public string ISComCatalogObject_ {get;set;}
}
