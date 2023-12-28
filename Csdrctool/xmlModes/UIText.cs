using System.Xml.Serialization;
[XmlRoot("UIText")]
public class UIText
{
     [XmlAttribute("Key")]
     public string Key {get;set;}
     [XmlAttribute("Text")]
     public string Text {get;set;}
}
