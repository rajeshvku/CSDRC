using System.Xml.Serialization;
[XmlRoot("ServiceInstall")]
public class ServiceInstall
{
     [XmlAttribute("ServiceInstall")]
     public string ServiceInstalls {get;set;}
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("DisplayName")]
     public string DisplayName {get;set;}
     [XmlAttribute("ServiceType")]
     public string ServiceType {get;set;}
     [XmlAttribute("StartType")]
     public string StartType {get;set;}
     [XmlAttribute("ErrorControl")]
     public string ErrorControl {get;set;}
     [XmlAttribute("LoadOrderGroup")]
     public string LoadOrderGroup {get;set;}
     [XmlAttribute("Dependencies")]
     public string Dependencies {get;set;}
     [XmlAttribute("StartName")]
     public string StartName {get;set;}
     [XmlAttribute("Password")]
     public string Password {get;set;}
     [XmlAttribute("Arguments")]
     public string Arguments {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("Description")]
     public string Description {get;set;}
}
