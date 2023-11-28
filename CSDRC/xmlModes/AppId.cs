using System.Xml.Serialization;
[XmlRoot("AppId")]
public class AppId
{
     [XmlAttribute("AppId")]
     public string AppIds {get;set;}
     [XmlAttribute("RemoteServerName")]
     public string RemoteServerName {get;set;}
     [XmlAttribute("LocalService")]
     public string LocalService {get;set;}
     [XmlAttribute("ServiceParameters")]
     public string ServiceParameters {get;set;}
     [XmlAttribute("DllSurrogate")]
     public string DllSurrogate {get;set;}
     [XmlAttribute("ActivateAtStorage")]
     public string ActivateAtStorage {get;set;}
     [XmlAttribute("RunAsInteractiveUser")]
     public string RunAsInteractiveUser {get;set;}
}
