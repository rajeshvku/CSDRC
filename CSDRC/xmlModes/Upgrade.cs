using System.Xml.Serialization;
[XmlRoot("Upgrade")]
public class Upgrade
{
     [XmlAttribute("UpgradeCode")]
     public string UpgradeCode {get;set;}
     [XmlAttribute("VersionMin")]
     public string VersionMin {get;set;}
     [XmlAttribute("VersionMax")]
     public string VersionMax {get;set;}
     [XmlAttribute("Language")]
     public string Language {get;set;}
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
     [XmlAttribute("Remove")]
     public string Remove {get;set;}
     [XmlAttribute("ActionProperty")]
     public string ActionProperty {get;set;}
     [XmlAttribute("ISDisplayName")]
     public string ISDisplayName {get;set;}
}
