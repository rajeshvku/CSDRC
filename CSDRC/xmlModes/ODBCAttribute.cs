using System.Xml.Serialization;
[XmlRoot("ODBCAttribute")]
public class ODBCAttribute
{
     [XmlAttribute("Driver_")]
     public string Driver_ {get;set;}
     [XmlAttribute("Attribute")]
     public string Attribute {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
}
