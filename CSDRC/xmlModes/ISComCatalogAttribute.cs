using System.Xml.Serialization;
[XmlRoot("ISComCatalogAttribute")]
public class ISComCatalogAttribute
{
     [XmlAttribute("ISComCatalogObject_")]
     public string ISComCatalogObject_ {get;set;}
     [XmlAttribute("ItemName")]
     public string ItemName {get;set;}
     [XmlAttribute("ItemValue")]
     public string ItemValue {get;set;}
}
