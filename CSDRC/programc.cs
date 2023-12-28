using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace CSDRC
{
    public class MasterD
    {
        public string Id { get; set; }
        public string Value { get; set; }
    }
    public class programc
    {
        private static void Mains(string[] args)
        {

            //string xmlStrisg = "E:\\Personal\\CSDRC\\CSDRC.TestWix\\Messages.wxs";




            List<MasterD> md = new List<MasterD>();
            //string xmlStrinsg = "E:\\Personal\\CSDRC\\CSDRC.TestWix\\Directories.wxs";

            //string xmlContent = @"<!-- Your XML content here -->";

            //try
            //{
            //    using StreamWriter sw = new StreamWriter("E:\\Personal\\CSDRC\\CSDRC.TestWix\\ModifiedDirectories.wxs");
            //    XDocument xndoc = XDocument.Load(xmlStrinsg);

            //    var directoryRefElements = xndoc.Descendants().Where(e => e.Name.LocalName == "DirectoryRef");
            //    var uniqueDirectoryRefs = new HashSet<string>();

            //    foreach (var directoryRefElement in directoryRefElements)
            //    {
            //        string directoryRefId = directoryRefElement.Attribute("Id")?.Value;

            //        if (!string.IsNullOrEmpty(directoryRefId) && uniqueDirectoryRefs.Add(directoryRefId))
            //        {
            //            sw.WriteLine($"<DirectoryRef Id=\"{directoryRefId}\">");

            //            foreach(var direc in directoryRefElements)
            //            {
            //                string directoryRef2Id = direc.Attribute("Id")?.Value;

            //                if (directoryRefId == directoryRef2Id)
            //                {
            //                    var directoryElements = direc.Elements().Where(e => e.Name.LocalName == "Directory");
            //                    foreach (var directoryElement in directoryElements)
            //                    {
            //                        string directoryId = directoryElement.Attribute("Id")?.Value;
            //                        string directoryName = directoryElement.Attribute("Name")?.Value;

            //                        if (!string.IsNullOrEmpty(directoryId) && !string.IsNullOrEmpty(directoryName))
            //                        {
            //                            sw.WriteLine($"  <Directory Id=\"{directoryId}\" Name=\"{directoryName}\" />");
            //                        }
            //                    }
            //                }

            //            }


            //            sw.WriteLine("</DirectoryRef>");
            //        }
            //    }
            //    sw.Close();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            //return;


            //XDocument xDoc = XDocument.Load(xmlStrinsg);
            //XNamespace nse = "http://schemas.microsoft.com/wix/2006/localization";

            //foreach (var element in xDoc.Descendants(nse + "String"))
            //{
            //    string id = element.Attribute("Id").Value;
            //    string pascalCase = ToPascalCase();
            //    string value = element.Value;
            //    md.Add(new MasterD { Id = id, Value = value });
            //    Console.WriteLine($"Id: {id}, Value: {value}");
            //    element.SetAttributeValue("Id", id);

            //}
            string xmlString = "E:\\Personal\\CSDRC\\CSDRC.TestWix\\ComponentsGeneratedw.wxs";
            string tringPath = "E:\\Personal\\CSDRC\\ReleaseDir\\Binaries\\";


            XDocument xdoc = XDocument.Load(xmlString);
            // Declare the namespace of the XML document
            XNamespace ns = "http://schemas.microsoft.com/wix/2006/wi";

            // Get all the component elements in the document
            var components = xdoc.Descendants(ns + "Binary");
            foreach (var component in components.Select((f, g) => new { f, g }))
            {
                var instanceCount = component.g + 1;
                // Add or update the Guid attribute with a new Guid value
                component.f.SetAttributeValue("Guid", "{" + Guid.NewGuid().ToString() + "}");
                string id = (string)component.f.Attribute("Id");
                string source = (string)component.f.Attribute("SourceFile");
                //string filePath = "!(loc.ISProductFolder)\\Redist\\Language Independent\\OS Independent\\setupicon.ico";

                string isProductFolderName = source.Substring(0, source.IndexOf('\\'));
                Console.WriteLine(isProductFolderName.Replace("!(loc.", "").Replace(")", ""));
                string trimId = isProductFolderName.Replace("!(loc.", "").Replace(")", "");
                var fg = md.FirstOrDefault(f => f.Id == trimId);
                if (fg != null)
                {
                    if (!string.IsNullOrEmpty(fg.Value))
                    {
                        var dd = fg.Value.Replace("F:", "E:");
                        // Create the directory if it doesn't exist
                        if (!System.IO.Directory.Exists(dd))
                        {
                            System.IO.Directory.CreateDirectory(dd);
                        }
                        tringPath = dd + "\\";

                    }


                }
                // Find the index of the first backslash
                int index = source.IndexOf('\\');


                // Check if the backslash is found
                if (index != -1)
                {
                    // Get the substring starting from the character after the first backslash
                    string result = source.Substring(index + 1);
                    int lindex = result.LastIndexOf('\\');
                    if (lindex != -1)
                    {
                        // Use Substring to get the path without the last part
                        string directoryPath = result.Substring(0, lindex);
                        // Create the directory if it doesn't exist
                        if (!System.IO.Directory.Exists(tringPath + directoryPath))
                        {
                            System.IO.Directory.CreateDirectory(tringPath + directoryPath);
                        }

                    }


                    Console.WriteLine("Result: " + result);
                    using StreamWriter sw = new StreamWriter(tringPath + result);
                    sw.Close();
                }
                else
                {
                    Console.WriteLine("Backslash not found in the string.");
                }

            }


        }
    }

}
