using System.Xml.Serialization;
[XmlRoot("ISChainPackage")]
public class ISChainPackage
{
     [XmlAttribute("Package")]
     public string Package {get;set;}
     [XmlAttribute("SourcePath")]
     public string SourcePath {get;set;}
     [XmlAttribute("ProductCode")]
     public string ProductCode {get;set;}
     [XmlAttribute("Order")]
     public string Order {get;set;}
     [XmlAttribute("Options")]
     public string Options {get;set;}
     [XmlAttribute("InstallCondition")]
     public string InstallCondition {get;set;}
     [XmlAttribute("RemoveCondition")]
     public string RemoveCondition {get;set;}
     [XmlAttribute("InstallProperties")]
     public string InstallProperties {get;set;}
     [XmlAttribute("RemoveProperties")]
     public string RemoveProperties {get;set;}
     [XmlAttribute("ISReleaseFlags")]
     public string ISReleaseFlags {get;set;}
     [XmlAttribute("DisplayName")]
     public string DisplayName {get;set;}
}
