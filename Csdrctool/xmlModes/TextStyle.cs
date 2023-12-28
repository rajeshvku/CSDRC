using System.Xml.Serialization;
[XmlRoot("TextStyle")]
public class TextStyle
{
     [XmlAttribute("TextStyle")]
     public string TextStyles {get;set;}
     [XmlAttribute("FaceName")]
     public string FaceName {get;set;}
     [XmlAttribute("Size")]
     public string Size {get;set;}
     [XmlAttribute("Color")]
     public string Color {get;set;}
     [XmlAttribute("StyleBits")]
     public string StyleBits {get;set;}
}
