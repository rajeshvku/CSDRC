using System.Xml.Serialization;
[XmlRoot("MsiPatchSequence")]
public class MsiPatchSequence
{
     [XmlAttribute("PatchConfiguration_")]
     public string PatchConfiguration_ {get;set;}
     [XmlAttribute("PatchFamily")]
     public string PatchFamily {get;set;}
     [XmlAttribute("Target")]
     public string Target {get;set;}
     [XmlAttribute("Sequence")]
     public string Sequence {get;set;}
     [XmlAttribute("Supersede")]
     public string Supersede {get;set;}
}
