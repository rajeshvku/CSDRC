using System.Xml.Serialization;
[XmlRoot("AppSearch")]
public class AppSearch
{
     [XmlAttribute("Property")]
     public string Property {get;set;}
     [XmlAttribute("Signature_")]
     public string Signature_ {get;set;}
}
