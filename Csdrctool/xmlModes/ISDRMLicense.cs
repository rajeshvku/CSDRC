using System.Xml.Serialization;
[XmlRoot("ISDRMLicense")]
public class ISDRMLicense
{
     [XmlAttribute("ISDRMLicense")]
     public string ISDRMLicenses {get;set;}
     [XmlAttribute("Description")]
     public string Description {get;set;}
     [XmlAttribute("ProjectVersion")]
     public string ProjectVersion {get;set;}
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
     [XmlAttribute("LicenseNumber")]
     public string LicenseNumber {get;set;}
     [XmlAttribute("RequestCode")]
     public string RequestCode {get;set;}
     [XmlAttribute("ResponseCode")]
     public string ResponseCode {get;set;}
}
