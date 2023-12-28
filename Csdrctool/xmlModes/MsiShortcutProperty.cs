using System.Xml.Serialization;
[XmlRoot("MsiShortcutProperty")]
public class MsiShortcutProperty
{
     [XmlAttribute("MsiShortcutProperty")]
     public string MsiShortcutPropertys {get;set;}
     [XmlAttribute("Shortcut_")]
     public string Shortcut_ {get;set;}
     [XmlAttribute("PropertyKey")]
     public string PropertyKey {get;set;}
     [XmlAttribute("PropVariantValue")]
     public string PropVariantValue {get;set;}
}
