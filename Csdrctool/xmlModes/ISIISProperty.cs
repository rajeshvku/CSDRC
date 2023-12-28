using System.Xml.Serialization;
[XmlRoot("ISIISProperty")]
public class ISIISProperty
{
     [XmlAttribute("ISIISProperty")]
     public string ISIISPropertys {get;set;}
     [XmlAttribute("ISIISItem_")]
     public string ISIISItem_ {get;set;}
     [XmlAttribute("Schema")]
     public string Schema {get;set;}
     [XmlAttribute("FriendlyName")]
     public string FriendlyName {get;set;}
     [XmlAttribute("MetaDataProp")]
     public string MetaDataProp {get;set;}
     [XmlAttribute("MetaDataType")]
     public string MetaDataType {get;set;}
     [XmlAttribute("MetaDataUserType")]
     public string MetaDataUserType {get;set;}
     [XmlAttribute("MetaDataAttributes")]
     public string MetaDataAttributes {get;set;}
     [XmlAttribute("MetaDataValue")]
     public string MetaDataValue {get;set;}
     [XmlAttribute("Order")]
     public string Order {get;set;}
     [XmlAttribute("ISAttributes")]
     public string ISAttributes {get;set;}
}
