using System.Xml.Serialization;
[XmlRoot("ISRelease")]
public class ISRelease
{
     [XmlAttribute("ISRelease")]
     public string ISReleases {get;set;}
     [XmlAttribute("ISProductConfiguration_")]
     public string ISProductConfiguration_ {get;set;}
     [XmlAttribute("BuildLocation")]
     public string BuildLocation {get;set;}
     [XmlAttribute("PackageName")]
     public string PackageName {get;set;}
     [XmlAttribute("Type")]
     public string Type {get;set;}
     [XmlAttribute("SupportedLanguagesUI")]
     public string SupportedLanguagesUI {get;set;}
     [XmlAttribute("MsiSourceType")]
     public string MsiSourceType {get;set;}
     [XmlAttribute("ReleaseType")]
     public string ReleaseType {get;set;}
     [XmlAttribute("Platforms")]
     public string Platforms {get;set;}
     [XmlAttribute("SupportedLanguagesData")]
     public string SupportedLanguagesData {get;set;}
     [XmlAttribute("DefaultLanguage")]
     public string DefaultLanguage {get;set;}
     [XmlAttribute("SupportedOSs")]
     public string SupportedOSs {get;set;}
     [XmlAttribute("DiskSize")]
     public string DiskSize {get;set;}
     [XmlAttribute("DiskSizeUnit")]
     public string DiskSizeUnit {get;set;}
     [XmlAttribute("DiskClusterSize")]
     public string DiskClusterSize {get;set;}
     [XmlAttribute("ReleaseFlags")]
     public string ReleaseFlags {get;set;}
     [XmlAttribute("DiskSpanning")]
     public string DiskSpanning {get;set;}
     [XmlAttribute("SynchMsi")]
     public string SynchMsi {get;set;}
     [XmlAttribute("MediaLocation")]
     public string MediaLocation {get;set;}
     [XmlAttribute("URLLocation")]
     public string URLLocation {get;set;}
     [XmlAttribute("DigitalURL")]
     public string DigitalURL {get;set;}
     [XmlAttribute("DigitalPVK")]
     public string DigitalPVK {get;set;}
     [XmlAttribute("DigitalSPC")]
     public string DigitalSPC {get;set;}
     [XmlAttribute("Password")]
     public string Password {get;set;}
     [XmlAttribute("VersionCopyright")]
     public string VersionCopyright {get;set;}
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
     [XmlAttribute("CDBrowser")]
     public string CDBrowser {get;set;}
     [XmlAttribute("DotNetBuildConfiguration")]
     public string DotNetBuildConfiguration {get;set;}
     [XmlAttribute("MsiCommandLine")]
     public string MsiCommandLine {get;set;}
     [XmlAttribute("ISSetupPrerequisiteLocation")]
     public string ISSetupPrerequisiteLocation {get;set;}
}
