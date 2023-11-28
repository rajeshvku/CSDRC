using System.Xml.Serialization;
[XmlRoot("Media")]
public class Media
{
     [XmlAttribute("DiskId")]
     public string DiskId {get;set;}
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
