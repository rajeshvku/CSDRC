using System.Xml.Serialization;
[XmlRoot("MsiDigitalSignature")]
public class MsiDigitalSignature
{
     [XmlAttribute("Table")]
     public string Table {get;set;}
     [XmlAttribute("SignObject")]
     public string SignObject {get;set;}
     [XmlAttribute("DigitalCertificate_")]
     public string DigitalCertificate_ {get;set;}
     [XmlAttribute("Hash")]
     public string Hash {get;set;}
}
