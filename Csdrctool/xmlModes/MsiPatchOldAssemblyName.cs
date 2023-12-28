using System.Xml.Serialization;
[XmlRoot("MsiPatchOldAssemblyName")]
public class MsiPatchOldAssemblyName
{
     [XmlAttribute("Assembly")]
     public string Assembly {get;set;}
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
}
