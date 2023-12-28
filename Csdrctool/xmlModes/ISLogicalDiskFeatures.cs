using System.Xml.Serialization;
[XmlRoot("ISLogicalDiskFeatures")]
public class ISLogicalDiskFeatures
{
     [XmlAttribute("ISLogicalDisk_")]
     public string ISLogicalDisk_ {get;set;}
     [XmlAttribute("ISProductConfiguration_")]
     public string ISProductConfiguration_ {get;set;}
     [XmlAttribute("ISRelease_")]
     public string ISRelease_ {get;set;}
     [XmlAttribute("Feature_")]
     public string Feature_ {get;set;}
     [XmlAttribute("Sequence")]
     public string Sequence {get;set;}
     [XmlAttribute("ISAttributes")]
     public string ISAttributes {get;set;}
}
