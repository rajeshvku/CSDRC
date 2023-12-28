using System.Xml.Serialization;
[XmlRoot("ISXmlLocator")]
public class ISXmlLocator
{
     [XmlAttribute("Signature_")]
     public string Signature_ {get;set;}
     [XmlAttribute("Parent")]
     public string Parent {get;set;}
     [XmlAttribute("Element")]
     public string Element {get;set;}
     [XmlAttribute("Attribute")]
     public string Attribute {get;set;}
     [XmlAttribute("ISAttributes")]
     public string ISAttributes {get;set;}
}
