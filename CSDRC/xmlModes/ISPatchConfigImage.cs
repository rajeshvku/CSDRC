using System.Xml.Serialization;
[XmlRoot("ISPatchConfigImage")]
public class ISPatchConfigImage
{
     [XmlAttribute("PatchConfiguration_")]
     public string PatchConfiguration_ {get;set;}
     [XmlAttribute("UpgradedImage_")]
     public string UpgradedImage_ {get;set;}
}
