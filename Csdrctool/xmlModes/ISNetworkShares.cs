using System.Xml.Serialization;
[XmlRoot("ISNetworkShares")]
public class ISNetworkShares
{
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("ServerName")]
     public string ServerName {get;set;}
     [XmlAttribute("ShareName")]
     public string ShareName {get;set;}
     [XmlAttribute("Remark")]
     public string Remark {get;set;}
     [XmlAttribute("Permission")]
     public string Permission {get;set;}
     [XmlAttribute("MaxUsers")]
     public string MaxUsers {get;set;}
}
