using System.Xml.Serialization;
[XmlRoot("MsiServiceConfigFailureActions")]
public class MsiServiceConfigFailureActions
{
     [XmlAttribute("MsiServiceConfigFailureActions")]
     public string MsiServiceConfigFailureActionss {get;set;}
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("Event")]
     public string Event {get;set;}
     [XmlAttribute("ResetPeriod")]
     public string ResetPeriod {get;set;}
     [XmlAttribute("RebootMessage")]
     public string RebootMessage {get;set;}
     [XmlAttribute("Command")]
     public string Command {get;set;}
     [XmlAttribute("Actions")]
     public string Actions {get;set;}
     [XmlAttribute("DelayActions")]
     public string DelayActions {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
}
