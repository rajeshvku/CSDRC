using System.Xml.Serialization;
[XmlRoot("ISFeatureSetupPrerequisites")]
public class ISFeatureSetupPrerequisites
{
     [XmlAttribute("Feature_")]
     public string Feature_ {get;set;}
     [XmlAttribute("ISSetupPrerequisites_")]
     public string ISSetupPrerequisites_ {get;set;}
}
