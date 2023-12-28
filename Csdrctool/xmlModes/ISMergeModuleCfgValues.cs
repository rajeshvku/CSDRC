using System.Xml.Serialization;
[XmlRoot("ISMergeModuleCfgValues")]
public class ISMergeModuleCfgValues
{
     [XmlAttribute("ISMergeModule_")]
     public string ISMergeModule_ {get;set;}
     [XmlAttribute("Language_")]
     public string Language_ {get;set;}
     [XmlAttribute("ModuleConfiguration_")]
     public string ModuleConfiguration_ {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
     [XmlAttribute("Format")]
     public string Format {get;set;}
     [XmlAttribute("Type")]
     public string Type {get;set;}
     [XmlAttribute("ContextData")]
     public string ContextData {get;set;}
     [XmlAttribute("DefaultValue")]
     public string DefaultValue {get;set;}
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
     [XmlAttribute("DisplayName")]
     public string DisplayName {get;set;}
     [XmlAttribute("Description")]
     public string Description {get;set;}
     [XmlAttribute("HelpLocation")]
     public string HelpLocation {get;set;}
     [XmlAttribute("HelpKeyword")]
     public string HelpKeyword {get;set;}
}
