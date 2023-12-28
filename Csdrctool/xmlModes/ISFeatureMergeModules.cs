using System.Xml.Serialization;
[XmlRoot("ISFeatureMergeModules")]
public class ISFeatureMergeModules
{
     [XmlAttribute("Feature_")]
     public string Feature_ {get;set;}
     [XmlAttribute("ISMergeModule_")]
     public string ISMergeModule_ {get;set;}
     [XmlAttribute("Language_")]
     public string Language_ {get;set;}
}
