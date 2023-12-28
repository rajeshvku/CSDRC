using System.Xml.Serialization;
[XmlRoot("ISSQLScriptReplace")]
public class ISSQLScriptReplace
{
     [XmlAttribute("ISSQLScriptReplace")]
     public string ISSQLScriptReplaces {get;set;}
     [XmlAttribute("ISSQLScriptFile_")]
     public string ISSQLScriptFile_ {get;set;}
     [XmlAttribute("Search")]
     public string Search {get;set;}
     [XmlAttribute("Replace")]
     public string Replace {get;set;}
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
}
