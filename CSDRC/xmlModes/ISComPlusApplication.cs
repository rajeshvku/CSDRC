using System.Xml.Serialization;
[XmlRoot("ISComPlusApplication")]
public class ISComPlusApplication
{
     [XmlAttribute("ISComCatalogObject_")]
     public string ISComCatalogObject_ {get;set;}
     [XmlAttribute("ComputerName")]
     public string ComputerName {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("ISAttributes")]
     public string ISAttributes {get;set;}
     [XmlAttribute("DepFiles")]
     public string DepFiles {get;set;}
}
