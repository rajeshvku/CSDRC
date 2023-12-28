using System.Xml.Serialization;
[XmlRoot("ProgId")]
public class ProgId
{
     [XmlAttribute("ProgId")]
     public string ProgIds {get;set;}
     [XmlAttribute("ProgId_Parent")]
     public string ProgId_Parent {get;set;}
     [XmlAttribute("Class_")]
     public string Class_ {get;set;}
     [XmlAttribute("Description")]
     public string Description {get;set;}
     [XmlAttribute("Icon_")]
     public string Icon_ {get;set;}
     [XmlAttribute("IconIndex")]
     public string IconIndex {get;set;}
     [XmlAttribute("ISAttributes")]
     public string ISAttributes {get;set;}
}
