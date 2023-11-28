using System.Xml.Serialization;
[XmlRoot("Shortcut")]
public class Shortcut
{
     [XmlAttribute("Shortcut")]
     public string Shortcuts {get;set;}
     [XmlAttribute("Directory_")]
     public string Directory_ {get;set;}
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("Target")]
     public string Target {get;set;}
     [XmlAttribute("Arguments")]
     public string Arguments {get;set;}
     [XmlAttribute("Description")]
     public string Description {get;set;}
     [XmlAttribute("Hotkey")]
     public string Hotkey {get;set;}
     [XmlAttribute("Icon_")]
     public string Icon_ {get;set;}
     [XmlAttribute("IconIndex")]
     public string IconIndex {get;set;}
     [XmlAttribute("ShowCmd")]
     public string ShowCmd {get;set;}
     [XmlAttribute("WkDir")]
     public string WkDir {get;set;}
     [XmlAttribute("DisplayResourceDLL")]
     public string DisplayResourceDLL {get;set;}
     [XmlAttribute("DisplayResourceId")]
     public string DisplayResourceId {get;set;}
     [XmlAttribute("DescriptionResourceDLL")]
     public string DescriptionResourceDLL {get;set;}
     [XmlAttribute("DescriptionResourceId")]
     public string DescriptionResourceId {get;set;}
     [XmlAttribute("ISComments")]
     public string ISComments {get;set;}
     [XmlAttribute("ISShortcutName")]
     public string ISShortcutName {get;set;}
     [XmlAttribute("ISAttributes")]
     public string ISAttributes {get;set;}
}
