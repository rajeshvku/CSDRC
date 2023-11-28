using System.Xml.Serialization;
[XmlRoot("ISScheduledTasks")]
public class ISScheduledTasks
{
     [XmlAttribute("ISScheduledTasks")]
     public string ISScheduledTaskss {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("TaskName")]
     public string TaskName {get;set;}
     [XmlAttribute("Comments")]
     public string Comments {get;set;}
     [XmlAttribute("TaskRun")]
     public string TaskRun {get;set;}
     [XmlAttribute("Arguments")]
     public string Arguments {get;set;}
     [XmlAttribute("WkDir")]
     public string WkDir {get;set;}
     [XmlAttribute("UserName")]
     public string UserName {get;set;}
     [XmlAttribute("Password")]
     public string Password {get;set;}
     [XmlAttribute("StartTime")]
     public string StartTime {get;set;}
     [XmlAttribute("Schedule")]
     public string Schedule {get;set;}
     [XmlAttribute("Modifier")]
     public string Modifier {get;set;}
     [XmlAttribute("Days")]
     public string Days {get;set;}
     [XmlAttribute("Months")]
     public string Months {get;set;}
     [XmlAttribute("IdleTime")]
     public string IdleTime {get;set;}
     [XmlAttribute("StartDate")]
     public string StartDate {get;set;}
     [XmlAttribute("EndDate")]
     public string EndDate {get;set;}
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
}
