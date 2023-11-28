using System.Xml.Serialization;
[XmlRoot("_Validation")]
public class _Validation
{
     [XmlAttribute("Table")]
     public string Table {get;set;}
     [XmlAttribute("Column")]
     public string Column {get;set;}
     [XmlAttribute("Nullable")]
     public string Nullable {get;set;}
     [XmlAttribute("MinValue")]
     public string MinValue {get;set;}
     [XmlAttribute("MaxValue")]
     public string MaxValue {get;set;}
     [XmlAttribute("KeyTable")]
     public string KeyTable {get;set;}
     [XmlAttribute("KeyColumn")]
     public string KeyColumn {get;set;}
     [XmlAttribute("Category")]
     public string Category {get;set;}
     [XmlAttribute("Set")]
     public string Set {get;set;}
     [XmlAttribute("Description")]
     public string Description {get;set;}
}
