using System.Xml.Serialization;
[XmlRoot("MsiDigitalCertificate")]
public class MsiDigitalCertificate
{
     [XmlAttribute("DigitalCertificate")]
     public string DigitalCertificate {get;set;}
     [XmlAttribute("CertData")]
     public string CertData {get;set;}
}
