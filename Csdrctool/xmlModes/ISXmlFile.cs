using System.Xml.Serialization;
[XmlRoot("ISXmlFile")]
public class ISXmlFile
{
     [XmlAttribute("ISXmlFile")]
     public string ISXmlFiles {get;set;}
     [XmlAttribute("FileName")]
     public string FileName {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("Directory")]
     public string Directory {get;set;}
     [XmlAttribute("ISAttributes")]
     public string ISAttributes {get;set;}
     [XmlAttribute("SelectionNamespaces")]
     public string SelectionNamespaces {get;set;}
     [XmlAttribute("Encoding")]
     public string Encoding {get;set;}
}
