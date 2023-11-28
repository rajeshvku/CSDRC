using System.Xml.Serialization;
[XmlRoot("ISTargetImage")]
public class ISTargetImage
{
     [XmlAttribute("UpgradedImage_")]
     public string UpgradedImage_ {get;set;}
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("MsiPath")]
     public string MsiPath {get;set;}
     [XmlAttribute("Order")]
     public string Order {get;set;}
     [XmlAttribute("Flags")]
     public string Flags {get;set;}
     [XmlAttribute("IgnoreMissingFiles")]
     public string IgnoreMissingFiles {get;set;}
}
