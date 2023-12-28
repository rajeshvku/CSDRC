using System.Xml.Serialization;
[XmlRoot("ODBCSourceAttribute")]
public class ODBCSourceAttribute
{
     [XmlAttribute("DataSource_")]
     public string DataSource_ {get;set;}
     [XmlAttribute("Attribute")]
     public string Attribute {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
}
