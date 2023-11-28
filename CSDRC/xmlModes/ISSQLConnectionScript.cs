using System.Xml.Serialization;
[XmlRoot("ISSQLConnectionScript")]
public class ISSQLConnectionScript
{
     [XmlAttribute("ISSQLConnection_")]
     public string ISSQLConnection_ {get;set;}
     [XmlAttribute("ISSQLScriptFile_")]
     public string ISSQLScriptFile_ {get;set;}
     [XmlAttribute("Order")]
     public string Order {get;set;}
}
