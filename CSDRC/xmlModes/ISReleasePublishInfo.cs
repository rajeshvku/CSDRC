using System.Xml.Serialization;
[XmlRoot("ISReleasePublishInfo")]
public class ISReleasePublishInfo
{
     [XmlAttribute("ISRelease_")]
     public string ISRelease_ {get;set;}
     [XmlAttribute("ISProductConfiguration_")]
     public string ISProductConfiguration_ {get;set;}
     [XmlAttribute("Repository")]
     public string Repository {get;set;}
     [XmlAttribute("DisplayName")]
     public string DisplayName {get;set;}
     [XmlAttribute("Publisher")]
     public string Publisher {get;set;}
     [XmlAttribute("Description")]
     public string Description {get;set;}
     [XmlAttribute("ISAttributes")]
     public string ISAttributes {get;set;}
}
