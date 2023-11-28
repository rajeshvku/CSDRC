using System.Xml.Serialization;
[XmlRoot("ISLocalDialog")]
public class ISLocalDialog
{
     [XmlAttribute("Dialog_")]
     public string Dialog_ {get;set;}
     [XmlAttribute("ISLanguage_")]
     public string ISLanguage_ {get;set;}
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
     [XmlAttribute("TextStyle_")]
     public string TextStyle_ {get;set;}
     [XmlAttribute("Width")]
     public string Width {get;set;}
     [XmlAttribute("Height")]
     public string Height {get;set;}
}
