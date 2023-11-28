using System.Xml.Serialization;
[XmlRoot("ServiceControl")]
public class ServiceControl
{
     [XmlAttribute("ServiceControl")]
     public string ServiceControls {get;set;}
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("Event")]
     public string Event {get;set;}
     [XmlAttribute("Arguments")]
     public string Arguments {get;set;}
     [XmlAttribute("Wait")]
     public string Wait {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
}
