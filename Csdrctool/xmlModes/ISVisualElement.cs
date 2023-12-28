using System.Xml.Serialization;
[XmlRoot("ISVisualElement")]
public class ISVisualElement
{
     [XmlAttribute("File_")]
     public string File_ {get;set;}
     [XmlAttribute("BackgroundColor")]
     public string BackgroundColor {get;set;}
     [XmlAttribute("ForegroundText")]
     public string ForegroundText {get;set;}
     [XmlAttribute("ShowNameOn150x150")]
     public string ShowNameOn150x150 {get;set;}
     [XmlAttribute("Square150x150Logo")]
     public string Square150x150Logo {get;set;}
     [XmlAttribute("Square70x70Logo")]
     public string Square70x70Logo {get;set;}
}
