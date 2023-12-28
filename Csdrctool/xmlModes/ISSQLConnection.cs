using System.Xml.Serialization;
[XmlRoot("ISSQLConnection")]
public class ISSQLConnection
{
     [XmlAttribute("ISSQLConnection")]
     public string ISSQLConnections {get;set;}
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
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
     [XmlAttribute("Order")]
     public string Order {get;set;}
     [XmlAttribute("Comments")]
     public string Comments {get;set;}
     [XmlAttribute("CmdTimeout")]
     public string CmdTimeout {get;set;}
     [XmlAttribute("BatchSeparator")]
     public string BatchSeparator {get;set;}
     [XmlAttribute("ScriptVersion_Table")]
     public string ScriptVersion_Table {get;set;}
     [XmlAttribute("ScriptVersion_Column")]
     public string ScriptVersion_Column {get;set;}
}
