using System.Xml.Serialization;
[XmlRoot("ISXmlElementAttrib")]
public class ISXmlElementAttrib
{
     [XmlAttribute("ISXmlElementAttrib")]
     public string ISXmlElementAttribs {get;set;}
     [XmlAttribute("ISXmlElement_")]
     public string ISXmlElement_ {get;set;}
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
     [XmlAttribute("ISAttributes")]
     public string ISAttributes {get;set;}
}
