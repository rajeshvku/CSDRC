using System.Xml.Serialization;
[XmlRoot("ISVirtualShortcut")]
public class ISVirtualShortcut
{
     [XmlAttribute("Shortcut_")]
     public string Shortcut_ {get;set;}
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
}
