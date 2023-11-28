using System.Xml.Serialization;
[XmlRoot("Font")]
public class Font
{
     [XmlAttribute("File_")]
     public string File_ {get;set;}
     [XmlAttribute("FontTitle")]
     public string FontTitle {get;set;}
}
