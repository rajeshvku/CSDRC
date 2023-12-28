using System.Xml.Serialization;
[XmlRoot("Registry")]
public class Registry
{
     [XmlAttribute("Registry")]
     public string Registrys {get;set;}
     [XmlAttribute("Root")]
     public string Root {get;set;}
     [XmlAttribute("Key")]
     public string Key {get;set;}
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("ISAttributes")]
     public string ISAttributes {get;set;}

    public string GetRegistry { get { return $"<RegistryValue Root=\"HKCU\"\r\nKey=\"{Key}\"\r\nName=\"{Name}\"\r\nType=\"integer\"\r\nValue=\"{Value}\"\r\nKeyPath=\"yes\" />"; } }
}
