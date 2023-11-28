using System.Xml.Serialization;
[XmlRoot("ISSQLRequirement")]
public class ISSQLRequirement
{
     [XmlAttribute("ISSQLRequirement")]
     public string ISSQLRequirements {get;set;}
     [XmlAttribute("ISSQLConnection_")]
     public string ISSQLConnection_ {get;set;}
     [XmlAttribute("MajorVersion")]
     public string MajorVersion {get;set;}
     [XmlAttribute("ServicePackLevel")]
     public string ServicePackLevel {get;set;}
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
     [XmlAttribute("ISSQLConnectionDBServer_")]
     public string ISSQLConnectionDBServer_ {get;set;}
}
