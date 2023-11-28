using System.Xml.Serialization;
[XmlRoot("MsiServiceConfig")]
public class MsiServiceConfig
{
     [XmlAttribute("MsiServiceConfig")]
     public string MsiServiceConfigs {get;set;}
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("Event")]
     public string Event {get;set;}
     [XmlAttribute("ConfigType")]
     public string ConfigType {get;set;}
     [XmlAttribute("Argument")]
     public string Argument {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
}
