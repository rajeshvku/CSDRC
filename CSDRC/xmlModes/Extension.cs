using System.Xml.Serialization;
[XmlRoot("Extension")]
public class Extension
{
     [XmlAttribute("Extension")]
     public string Extensions {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("ProgId_")]
     public string ProgId_ {get;set;}
     [XmlAttribute("MIME_")]
     public string MIME_ {get;set;}
     [XmlAttribute("Feature_")]
     public string Feature_ {get;set;}
}
