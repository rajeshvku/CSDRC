using System.Xml.Serialization;
[XmlRoot("MsiLockPermissionsEx")]
public class MsiLockPermissionsEx
{
     [XmlAttribute("MsiLockPermissionsEx")]
     public string MsiLockPermissionsExs {get;set;}
     [XmlAttribute("LockObject")]
     public string LockObject {get;set;}
     [XmlAttribute("Table")]
     public string Table {get;set;}
     [XmlAttribute("SDDLText")]
     public string SDDLText {get;set;}
     [XmlAttribute("Condition")]
     public string Condition {get;set;}
}
