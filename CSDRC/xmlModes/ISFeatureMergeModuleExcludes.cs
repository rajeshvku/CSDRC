using System.Xml.Serialization;
[XmlRoot("ISFeatureMergeModuleExcludes")]
public class ISFeatureMergeModuleExcludes
{
     [XmlAttribute("Feature_")]
     public string Feature_ {get;set;}
     [XmlAttribute("ModuleID")]
     public string ModuleID {get;set;}
     [XmlAttribute("Language")]
     public string Language {get;set;}
}
