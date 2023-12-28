using System.Xml.Serialization;
[XmlRoot("ISSetupType")]
public class ISSetupType
{
     [XmlAttribute("ISSetupType")]
     public string ISSetupTypes {get;set;}
     [XmlAttribute("Description")]
     public string Description {get;set;}
     [XmlAttribute("Display_Name")]
     public string Display_Name {get;set;}
     [XmlAttribute("Display")]
     public string Display {get;set;}
     [XmlAttribute("Comments")]
     public string Comments {get;set;}
}
