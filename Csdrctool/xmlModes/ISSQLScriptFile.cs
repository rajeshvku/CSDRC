using System.Xml.Serialization;
[XmlRoot("ISSQLScriptFile")]
public class ISSQLScriptFile
{
     [XmlAttribute("ISSQLScriptFile")]
     public string ISSQLScriptFiles {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("Scheduling")]
     public string Scheduling {get;set;}
     [XmlAttribute("InstallText")]
     public string InstallText {get;set;}
     [XmlAttribute("UninstallText")]
     public string UninstallText {get;set;}
     [XmlAttribute("ISBuildSourcePath")]
     public string ISBuildSourcePath {get;set;}
     [XmlAttribute("Comments")]
     public string Comments {get;set;}
     [XmlAttribute("ErrorHandling")]
     public string ErrorHandling {get;set;}
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
     [XmlAttribute("Version")]
     public string Version {get;set;}
     [XmlAttribute("Condition")]
     public string Condition {get;set;}
     [XmlAttribute("DisplayName")]
     public string DisplayName {get;set;}
}
