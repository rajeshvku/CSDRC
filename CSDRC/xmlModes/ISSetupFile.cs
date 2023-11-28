using System.Xml.Serialization;
[XmlRoot("ISSetupFile")]
public class ISSetupFile
{
     [XmlAttribute("ISSetupFile")]
     public string ISSetupFiles {get;set;}
     [XmlAttribute("FileName")]
     public string FileName {get;set;}
     [XmlAttribute("Stream")]
     public string Stream {get;set;}
     [XmlAttribute("Language")]
     public string Language {get;set;}
     [XmlAttribute("Splash")]
     public string Splash {get;set;}
     [XmlAttribute("Path")]
     public string Path {get;set;}
}
