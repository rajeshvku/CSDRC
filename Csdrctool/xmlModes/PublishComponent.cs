using System.Xml.Serialization;
[XmlRoot("PublishComponent")]
public class PublishComponent
{
     [XmlAttribute("ComponentId")]
     public string ComponentId {get;set;}
     [XmlAttribute("Qualifier")]
     public string Qualifier {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("AppData")]
     public string AppData {get;set;}
     [XmlAttribute("Feature_")]
     public string Feature_ {get;set;}
}
