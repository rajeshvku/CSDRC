using System.Xml.Serialization;
[XmlRoot("ODBCDataSource")]
public class ODBCDataSource
{
     [XmlAttribute("DataSource")]
     public string DataSource {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("Description")]
     public string Description {get;set;}
     [XmlAttribute("DriverDescription")]
     public string DriverDescription {get;set;}
     [XmlAttribute("Registration")]
     public string Registration {get;set;}
}
