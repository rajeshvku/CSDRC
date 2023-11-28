using System.Xml.Serialization;
[XmlRoot("MsiPackageCertificate")]
public class MsiPackageCertificate
{
     [XmlAttribute("PackageCertificate")]
     public string PackageCertificate {get;set;}
     [XmlAttribute("DigitalCertificate_")]
     public string DigitalCertificate_ {get;set;}
}
