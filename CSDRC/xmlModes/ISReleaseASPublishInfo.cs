using System.Xml.Serialization;
[XmlRoot("ISReleaseASPublishInfo")]
public class ISReleaseASPublishInfo
{
     [XmlAttribute("ISRelease_")]
     public string ISRelease_ {get;set;}
     [XmlAttribute("ISProductConfiguration_")]
     public string ISProductConfiguration_ {get;set;}
     [XmlAttribute("Property")]
     public string Property {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
}
