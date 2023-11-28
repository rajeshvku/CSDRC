using System.Xml.Serialization;
[XmlRoot("ISSQLScriptError")]
public class ISSQLScriptError
{
     [XmlAttribute("ErrNumber")]
     public string ErrNumber {get;set;}
     [XmlAttribute("ISSQLScriptFile_")]
     public string ISSQLScriptFile_ {get;set;}
     [XmlAttribute("ErrHandling")]
     public string ErrHandling {get;set;}
     [XmlAttribute("Message")]
     public string Message {get;set;}
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
}
