using System.Xml.Serialization;
[XmlRoot("ISUpgradedImage")]
public class ISUpgradedImage
{
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("MsiPath")]
     public string MsiPath {get;set;}
     [XmlAttribute("Family")]
     public string Family {get;set;}
}
