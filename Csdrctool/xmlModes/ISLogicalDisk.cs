using System.Xml.Serialization;
[XmlRoot("ISLogicalDisk")]
public class ISLogicalDisk
{
     [XmlAttribute("DiskId")]
     public string DiskId {get;set;}
     [XmlAttribute("ISProductConfiguration_")]
     public string ISProductConfiguration_ {get;set;}
     [XmlAttribute("ISRelease_")]
     public string ISRelease_ {get;set;}
     [XmlAttribute("LastSequence")]
     public string LastSequence {get;set;}
     [XmlAttribute("DiskPrompt")]
     public string DiskPrompt {get;set;}
     [XmlAttribute("Cabinet")]
     public string Cabinet {get;set;}
     [XmlAttribute("VolumeLabel")]
     public string VolumeLabel {get;set;}
     [XmlAttribute("Source")]
     public string Source {get;set;}
}
