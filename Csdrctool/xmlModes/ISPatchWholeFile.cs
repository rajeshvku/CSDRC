using System.Xml.Serialization;
[XmlRoot("ISPatchWholeFile")]
public class ISPatchWholeFile
{
     [XmlAttribute("UpgradedImage")]
     public string UpgradedImage {get;set;}
     [XmlAttribute("FileKey")]
     public string FileKey {get;set;}
     [XmlAttribute("Component")]
     public string Component {get;set;}
}
