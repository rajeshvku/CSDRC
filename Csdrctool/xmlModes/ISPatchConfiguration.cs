using System.Xml.Serialization;
[XmlRoot("ISPatchConfiguration")]
public class ISPatchConfiguration
{
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("CanPCDiffer")]
     public string CanPCDiffer {get;set;}
     [XmlAttribute("CanPVDiffer")]
     public string CanPVDiffer {get;set;}
     [XmlAttribute("IncludeWholeFiles")]
     public string IncludeWholeFiles {get;set;}
     [XmlAttribute("LeaveDecompressed")]
     public string LeaveDecompressed {get;set;}
     [XmlAttribute("OptimizeForSize")]
     public string OptimizeForSize {get;set;}
     [XmlAttribute("EnablePatchCache")]
     public string EnablePatchCache {get;set;}
     [XmlAttribute("PatchCacheDir")]
     public string PatchCacheDir {get;set;}
     [XmlAttribute("Flags")]
     public string Flags {get;set;}
     [XmlAttribute("PatchGuidsToReplace")]
     public string PatchGuidsToReplace {get;set;}
     [XmlAttribute("TargetProductCodes")]
     public string TargetProductCodes {get;set;}
     [XmlAttribute("PatchGuid")]
     public string PatchGuid {get;set;}
     [XmlAttribute("OutputPath")]
     public string OutputPath {get;set;}
     [XmlAttribute("MinMsiVersion")]
     public string MinMsiVersion {get;set;}
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
}
