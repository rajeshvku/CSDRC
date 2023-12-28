using System.Xml.Serialization;
[XmlRoot("ISUpgradeMsiItem")]
public class ISUpgradeMsiItem
{
     [XmlAttribute("UpgradeItem")]
     public string UpgradeItem {get;set;}
     [XmlAttribute("ObjectSetupPath")]
     public string ObjectSetupPath {get;set;}
     [XmlAttribute("ISReleaseFlags")]
     public string ISReleaseFlags {get;set;}
     [XmlAttribute("ISAttributes")]
     public string ISAttributes {get;set;}
}
