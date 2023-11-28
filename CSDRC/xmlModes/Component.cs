using System.Xml.Serialization;
[XmlRoot("Component")]
public class Component
{
     [XmlAttribute("Component")]
     public string Components {get;set;}
     [XmlAttribute("ComponentId")]
     public string ComponentId {get;set;}
     [XmlAttribute("Directory_")]
     public string Directory_ {get;set;}
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
     [XmlAttribute("Condition")]
     public string Condition {get;set;}
     [XmlAttribute("KeyPath")]
     public string KeyPath {get;set;}
     [XmlAttribute("ISAttributes")]
     public string ISAttributes {get;set;}
     [XmlAttribute("ISComments")]
     public string ISComments {get;set;}
     [XmlAttribute("ISScanAtBuildFile")]
     public string ISScanAtBuildFile {get;set;}
     [XmlAttribute("ISRegFileToMergeAtBuild")]
     public string ISRegFileToMergeAtBuild {get;set;}
     [XmlAttribute("ISDotNetInstallerArgsInstall")]
     public string ISDotNetInstallerArgsInstall {get;set;}
     [XmlAttribute("ISDotNetInstallerArgsCommit")]
     public string ISDotNetInstallerArgsCommit {get;set;}
     [XmlAttribute("ISDotNetInstallerArgsUninstall")]
     public string ISDotNetInstallerArgsUninstall {get;set;}
     [XmlAttribute("ISDotNetInstallerArgsRollback")]
     public string ISDotNetInstallerArgsRollback {get;set;}
}
