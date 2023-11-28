using System.Xml.Serialization;
[XmlRoot("Verb")]
public class Verb
{
     [XmlAttribute("Extension_")]
     public string Extension_ {get;set;}
     [XmlAttribute("Verb")]
     public string Verbs {get;set;}
     [XmlAttribute("Sequence")]
     public string Sequence {get;set;}
     [XmlAttribute("Command")]
     public string Command {get;set;}
     [XmlAttribute("Argument")]
     public string Argument {get;set;}
}
