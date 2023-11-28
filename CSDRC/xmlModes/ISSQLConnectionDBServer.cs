using System.Xml.Serialization;
[XmlRoot("ISSQLConnectionDBServer")]
public class ISSQLConnectionDBServer
{
     [XmlAttribute("ISSQLConnectionDBServer")]
     public string ISSQLConnectionDBServers {get;set;}
     [XmlAttribute("ISSQLConnection_")]
     public string ISSQLConnection_ {get;set;}
     [XmlAttribute("ISSQLDBMetaData_")]
     public string ISSQLDBMetaData_ {get;set;}
     [XmlAttribute("Order")]
     public string Order {get;set;}
}
