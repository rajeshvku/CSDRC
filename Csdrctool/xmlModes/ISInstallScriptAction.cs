using System.Xml.Serialization;
[XmlRoot("ISInstallScriptAction")]
public class ISInstallScriptAction
{
     [XmlAttribute("EntryPoint")]
     public string EntryPoint {get;set;}
     [XmlAttribute("Type")]
     public string Type {get;set;}
     [XmlAttribute("Source")]
     public string Source {get;set;}
     [XmlAttribute("Target")]
     public string Target {get;set;}
}
