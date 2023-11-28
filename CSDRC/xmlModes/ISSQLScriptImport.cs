using System.Xml.Serialization;
[XmlRoot("ISSQLScriptImport")]
public class ISSQLScriptImport
{
     [XmlAttribute("ISSQLScriptFile_")]
     public string ISSQLScriptFile_ {get;set;}
     [XmlAttribute("Server")]
     public string Server {get;set;}
     [XmlAttribute("Database")]
     public string Database {get;set;}
     [XmlAttribute("UserName")]
     public string UserName {get;set;}
     [XmlAttribute("Password")]
     public string Password {get;set;}
     [XmlAttribute("Authentication")]
     public string Authentication {get;set;}
     [XmlAttribute("IncludeTables")]
     public string IncludeTables {get;set;}
     [XmlAttribute("ExcludeTables")]
     public string ExcludeTables {get;set;}
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
}
