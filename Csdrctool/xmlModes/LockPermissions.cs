using System.Xml.Serialization;
[XmlRoot("LockPermissions")]
public class LockPermissions
{
     [XmlAttribute("LockObject")]
     public string LockObject {get;set;}
     [XmlAttribute("Table")]
     public string Table {get;set;}
     [XmlAttribute("Domain")]
     public string Domain {get;set;}
     [XmlAttribute("User")]
     public string User {get;set;}
     [XmlAttribute("Permission")]
     public string Permission {get;set;}
}
