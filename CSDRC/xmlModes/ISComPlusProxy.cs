using System.Xml.Serialization;
[XmlRoot("ISComPlusProxy")]
public class ISComPlusProxy
{
     [XmlAttribute("ISComPlusProxy")]
     public string ISComPlusProxys {get;set;}
     [XmlAttribute("ISComPlusApplication_")]
     public string ISComPlusApplication_ {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("ISAttributes")]
     public string ISAttributes {get;set;}
     [XmlAttribute("DepFiles")]
     public string DepFiles {get;set;}
}
