using System.Xml.Serialization;
[XmlRoot("PatchPackage")]
public class PatchPackage
{
     [XmlAttribute("PatchId")]
     public string PatchId {get;set;}
     [XmlAttribute("Media_")]
     public string Media_ {get;set;}
}
