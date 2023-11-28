using System.Xml.Serialization;
[XmlRoot("ISReleaseExtended")]
public class ISReleaseExtended
{
     [XmlAttribute("ISRelease_")]
     public string ISRelease_ {get;set;}
     [XmlAttribute("ISProductConfiguration_")]
     public string ISProductConfiguration_ {get;set;}
     [XmlAttribute("WebType")]
     public string WebType {get;set;}
     [XmlAttribute("WebURL")]
     public string WebURL {get;set;}
     [XmlAttribute("WebCabSize")]
     public string WebCabSize {get;set;}
     [XmlAttribute("OneClickCabName")]
     public string OneClickCabName {get;set;}
     [XmlAttribute("OneClickHtmlName")]
     public string OneClickHtmlName {get;set;}
     [XmlAttribute("WebLocalCachePath")]
     public string WebLocalCachePath {get;set;}
     [XmlAttribute("EngineLocation")]
     public string EngineLocation {get;set;}
     [XmlAttribute("Win9xMsiUrl")]
     public string Win9xMsiUrl {get;set;}
     [XmlAttribute("WinNTMsiUrl")]
     public string WinNTMsiUrl {get;set;}
     [XmlAttribute("ISEngineLocation")]
     public string ISEngineLocation {get;set;}
     [XmlAttribute("ISEngineURL")]
     public string ISEngineURL {get;set;}
     [XmlAttribute("OneClickTargetBrowser")]
     public string OneClickTargetBrowser {get;set;}
     [XmlAttribute("DigitalCertificateIdNS")]
     public string DigitalCertificateIdNS {get;set;}
     [XmlAttribute("DigitalCertificateDBaseNS")]
     public string DigitalCertificateDBaseNS {get;set;}
     [XmlAttribute("DigitalCertificatePasswordNS")]
     public string DigitalCertificatePasswordNS {get;set;}
     [XmlAttribute("DotNetRedistLocation")]
     public string DotNetRedistLocation {get;set;}
     [XmlAttribute("DotNetRedistURL")]
     public string DotNetRedistURL {get;set;}
     [XmlAttribute("DotNetVersion")]
     public string DotNetVersion {get;set;}
     [XmlAttribute("DotNetBaseLanguage")]
     public string DotNetBaseLanguage {get;set;}
     [XmlAttribute("DotNetLangaugePacks")]
     public string DotNetLangaugePacks {get;set;}
     [XmlAttribute("DotNetFxCmdLine")]
     public string DotNetFxCmdLine {get;set;}
     [XmlAttribute("DotNetLangPackCmdLine")]
     public string DotNetLangPackCmdLine {get;set;}
     [XmlAttribute("JSharpCmdLine")]
     public string JSharpCmdLine {get;set;}
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
     [XmlAttribute("JSharpRedistLocation")]
     public string JSharpRedistLocation {get;set;}
     [XmlAttribute("MsiEngineVersion")]
     public string MsiEngineVersion {get;set;}
     [XmlAttribute("WinMsi30Url")]
     public string WinMsi30Url {get;set;}
     [XmlAttribute("CertPassword")]
     public string CertPassword {get;set;}
}
