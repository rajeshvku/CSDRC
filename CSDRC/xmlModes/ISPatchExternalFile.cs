using System.Xml.Serialization;
[XmlRoot("ISPatchExternalFile")]
public class ISPatchExternalFile
{
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("ISUpgradedImage_")]
     public string ISUpgradedImage_ {get;set;}
     [XmlAttribute("FileKey")]
     public string FileKey {get;set;}
     [XmlAttribute("FilePath")]
     public string FilePath {get;set;}
}
