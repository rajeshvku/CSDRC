using System.Xml.Serialization;
[XmlRoot("ISMergeModule")]
public class ISMergeModule
{
     [XmlAttribute("ISMergeModule")]
     public string ISMergeModules {get;set;}
     [XmlAttribute("Language")]
     public string Language {get;set;}
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("Destination")]
     public string Destination {get;set;}
     [XmlAttribute("ISAttributes")]
     public string ISAttributes {get;set;}
}
