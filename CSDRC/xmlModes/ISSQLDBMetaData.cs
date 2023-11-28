using System.Xml.Serialization;
[XmlRoot("ISSQLDBMetaData")]
public class ISSQLDBMetaData
{
     [XmlAttribute("ISSQLDBMetaData")]
     public string ISSQLDBMetaDatas {get;set;}
     [XmlAttribute("DisplayName")]
     public string DisplayName {get;set;}
     [XmlAttribute("AdoDriverName")]
     public string AdoDriverName {get;set;}
     [XmlAttribute("AdoCxnDriver")]
     public string AdoCxnDriver {get;set;}
     [XmlAttribute("AdoCxnServer")]
     public string AdoCxnServer {get;set;}
     [XmlAttribute("AdoCxnDatabase")]
     public string AdoCxnDatabase {get;set;}
     [XmlAttribute("AdoCxnUserID")]
     public string AdoCxnUserID {get;set;}
     [XmlAttribute("AdoCxnPassword")]
     public string AdoCxnPassword {get;set;}
     [XmlAttribute("AdoCxnWindowsSecurity")]
     public string AdoCxnWindowsSecurity {get;set;}
     [XmlAttribute("AdoCxnNetLibrary")]
     public string AdoCxnNetLibrary {get;set;}
     [XmlAttribute("TestDatabaseCmd")]
     public string TestDatabaseCmd {get;set;}
     [XmlAttribute("TestTableCmd")]
     public string TestTableCmd {get;set;}
     [XmlAttribute("VersionInfoCmd")]
     public string VersionInfoCmd {get;set;}
     [XmlAttribute("VersionBeginToken")]
     public string VersionBeginToken {get;set;}
     [XmlAttribute("VersionEndToken")]
     public string VersionEndToken {get;set;}
     [XmlAttribute("LocalInstanceNames")]
     public string LocalInstanceNames {get;set;}
     [XmlAttribute("CreateDbCmd")]
     public string CreateDbCmd {get;set;}
     [XmlAttribute("SwitchDbCmd")]
     public string SwitchDbCmd {get;set;}
     [XmlAttribute("ISAttributes")]
     public string ISAttributes {get;set;}
     [XmlAttribute("TestTableCmd2")]
     public string TestTableCmd2 {get;set;}
     [XmlAttribute("WinAuthentUserId")]
     public string WinAuthentUserId {get;set;}
     [XmlAttribute("DsnODBCName")]
     public string DsnODBCName {get;set;}
     [XmlAttribute("AdoCxnPort")]
     public string AdoCxnPort {get;set;}
     [XmlAttribute("AdoCxnAdditional")]
     public string AdoCxnAdditional {get;set;}
     [XmlAttribute("QueryDatabasesCmd")]
     public string QueryDatabasesCmd {get;set;}
     [XmlAttribute("CreateTableCmd")]
     public string CreateTableCmd {get;set;}
     [XmlAttribute("InsertRecordCmd")]
     public string InsertRecordCmd {get;set;}
     [XmlAttribute("SelectTableCmd")]
     public string SelectTableCmd {get;set;}
     [XmlAttribute("ScriptVersion_Table")]
     public string ScriptVersion_Table {get;set;}
     [XmlAttribute("ScriptVersion_Column")]
     public string ScriptVersion_Column {get;set;}
     [XmlAttribute("ScriptVersion_ColumnType")]
     public string ScriptVersion_ColumnType {get;set;}
}
