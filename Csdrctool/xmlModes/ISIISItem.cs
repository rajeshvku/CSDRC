using System.Xml.Serialization;
[XmlRoot("ISIISItem")]
public class ISIISItem
{
     [XmlAttribute("ISIISItem")]
     public string ISIISItems {get;set;}
     [XmlAttribute("ISIISItem_Parent")]
     public string ISIISItem_Parent {get;set;}
     [XmlAttribute("DisplayName")]
     public string DisplayName {get;set;}
     [XmlAttribute("Type")]
     public string Type {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
}
