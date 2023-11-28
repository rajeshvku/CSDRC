using System.Xml.Serialization;
[XmlRoot("Dialog")]
public class Dialog
{
     [XmlAttribute("Dialog")]
     public string Dialogs {get;set;}
     [XmlAttribute("HCentering")]
     public string HCentering {get;set;}
     [XmlAttribute("VCentering")]
     public string VCentering {get;set;}
     [XmlAttribute("Width")]
     public string Width {get;set;}
     [XmlAttribute("Height")]
     public string Height {get;set;}
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
     [XmlAttribute("Title")]
     public string Title {get;set;}
     [XmlAttribute("Control_First")]
     public string Control_First {get;set;}
     [XmlAttribute("Control_Default")]
     public string Control_Default {get;set;}
     [XmlAttribute("Control_Cancel")]
     public string Control_Cancel {get;set;}
     [XmlAttribute("ISComments")]
     public string ISComments {get;set;}
     [XmlAttribute("TextStyle_")]
     public string TextStyle_ {get;set;}
     [XmlAttribute("ISWindowStyle")]
     public string ISWindowStyle {get;set;}
     [XmlAttribute("ISResourceId")]
     public string ISResourceId {get;set;}
}
