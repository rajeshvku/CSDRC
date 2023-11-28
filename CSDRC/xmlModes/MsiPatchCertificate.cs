using System.Xml.Serialization;
[XmlRoot("MsiPatchCertificate")]
public class MsiPatchCertificate
{
     [XmlAttribute("PatchCertificate")]
     public string PatchCertificate {get;set;}
     [XmlAttribute("DigitalCertificate_")]
     public string DigitalCertificate_ {get;set;}
}
