using System.Xml.Serialization;
[XmlRoot("Feature")]
public class Feature
{
     [XmlAttribute("Feature")]
     public string Features {get;set;}
     [XmlAttribute("Feature_Parent")]
     public string Feature_Parent {get;set;}
     [XmlAttribute("Title")]
     public string Title {get;set;}
     [XmlAttribute("Description")]
     public string Description {get;set;}
     [XmlAttribute("Display")]
     public string Display {get;set;}
     [XmlAttribute("Level")]
     public string Level {get;set;}
     [XmlAttribute("Directory_")]
     public string Directory_ {get;set;}
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
     [XmlAttribute("ISReleaseFlags")]
     public string ISReleaseFlags {get;set;}
     [XmlAttribute("ISComments")]
     public string ISComments {get;set;}
     [XmlAttribute("ISFeatureCabName")]
     public string ISFeatureCabName {get;set;}
     [XmlAttribute("ISProFeatureName")]
     public string ISProFeatureName {get;set;}
}
