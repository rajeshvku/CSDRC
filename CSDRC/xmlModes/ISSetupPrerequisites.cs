using System.Xml.Serialization;
[XmlRoot("ISSetupPrerequisites")]
public class ISSetupPrerequisites
{
     [XmlAttribute("ISSetupPrerequisites")]
     public string ISSetupPrerequisitess {get;set;}
     [XmlAttribute("ISBuildSourcePath")]
     public string ISBuildSourcePath {get;set;}
     [XmlAttribute("Order")]
     public string Order {get;set;}
     [XmlAttribute("ISSetupLocation")]
     public string ISSetupLocation {get;set;}
     [XmlAttribute("ISReleaseFlags")]
     public string ISReleaseFlags {get;set;}
}
