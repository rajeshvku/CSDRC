using System.Xml.Serialization;
[XmlRoot("ISDIMDependency")]
public class ISDIMDependency
{
     [XmlAttribute("ISDIMReference_")]
     public string ISDIMReference_ {get;set;}
     [XmlAttribute("RequiredUUID")]
     public string RequiredUUID {get;set;}
     [XmlAttribute("RequiredMajorVersion")]
     public string RequiredMajorVersion {get;set;}
     [XmlAttribute("RequiredMinorVersion")]
     public string RequiredMinorVersion {get;set;}
     [XmlAttribute("RequiredBuildVersion")]
     public string RequiredBuildVersion {get;set;}
     [XmlAttribute("RequiredRevisionVersion")]
     public string RequiredRevisionVersion {get;set;}
}
