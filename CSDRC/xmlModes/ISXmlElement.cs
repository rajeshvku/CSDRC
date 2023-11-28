using System.Xml.Serialization;
[XmlRoot("ISXmlElement")]
public class ISXmlElement
{
     [XmlAttribute("ISXmlElement")]
     public string ISXmlElements {get;set;}
     [XmlAttribute("ISXmlFile_")]
     public string ISXmlFile_ {get;set;}
     [XmlAttribute("ISXmlElement_Parent")]
     public string ISXmlElement_Parent {get;set;}
     [XmlAttribute("XPath")]
     public string XPath {get;set;}
     [XmlAttribute("Content")]
     public string Content {get;set;}
     [XmlAttribute("ISAttributes")]
     public string ISAttributes {get;set;}
}
