using System.Xml.Serialization;
[XmlRoot("Class")]
public class Class
{
     [XmlAttribute("CLSID")]
     public string CLSID {get;set;}
     [XmlAttribute("Context")]
     public string Context {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("ProgId_Default")]
     public string ProgId_Default {get;set;}
     [XmlAttribute("Description")]
     public string Description {get;set;}
     [XmlAttribute("AppId_")]
     public string AppId_ {get;set;}
     [XmlAttribute("FileTypeMask")]
     public string FileTypeMask {get;set;}
     [XmlAttribute("Icon_")]
     public string Icon_ {get;set;}
     [XmlAttribute("IconIndex")]
     public string IconIndex {get;set;}
     [XmlAttribute("DefInprocHandler")]
     public string DefInprocHandler {get;set;}
     [XmlAttribute("Argument")]
     public string Argument {get;set;}
     [XmlAttribute("Feature_")]
     public string Feature_ {get;set;}
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
}
