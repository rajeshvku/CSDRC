using System.Xml.Serialization;
[XmlRoot("ControlEvent")]
public class ControlEvent
{
     [XmlAttribute("Dialog_")]
     public string Dialog_ {get;set;}
     [XmlAttribute("Control_")]
     public string Control_ {get;set;}
     [XmlAttribute("Event")]
     public string Event {get;set;}
     [XmlAttribute("Argument")]
     public string Argument {get;set;}
     [XmlAttribute("Condition")]
     public string Condition {get;set;}
     [XmlAttribute("Ordering")]
     public string Ordering {get;set;}

     public string GetControlEvent { get { return $"<Publish Event=\"{Event}\"\r\nValue=\"{Argument}\" Order=\"{Ordering}\"><![CDATA[{Condition}]]></Publish>"; } }
}
