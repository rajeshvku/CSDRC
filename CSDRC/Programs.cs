using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSDRC
{
    internal class Programs
    {
        private static void Mains(string[] args)
        {
            // Load the XML document from a file
            XDocument xdoc = XDocument.Load("E:\\Personal\\CSDRC\\CSDRC.TestWix\\ComponentsGeneratedw.wxs");

            // Declare the namespace of the XML document
            XNamespace ns = "http://schemas.microsoft.com/wix/2006/wi";

            // Get all the component elements in the document
            var components = xdoc.Descendants(ns + "Component");

            // Loop through each component element
            foreach (var component in components.Select((f, g) => new { f,g}))
            {
                var instanceCount = component.g + 1;
                // Add or update the Guid attribute with a new Guid value
                component.f.SetAttributeValue("Guid","{"+ Guid.NewGuid().ToString()+"}");
                string id = (string)component.f.Attribute("Id");
                if(!string.IsNullOrEmpty(id))
                {
                    id = id.Replace(".dll", "")
                    .Replace(".icm", "")
                    .Replace(".ini", "")
                    .Replace(".lic", "")
                    .Replace(".ocx", "")
                    .Replace(".exe", "")
                    .Replace(".dll1", "")
                    .Replace(".reg", "")
                    .Replace(".", "");
                    id += "File";
                }
                else
                {
                    component.f.SetAttributeValue("Id", $"compA{instanceCount.ToString("D3")}");
                }

            }
            // Get all the component elements in the document
            var files = xdoc.Descendants(ns + "File");

            // Loop through each component element
            foreach (var component in files)
            {
                // Add or update the Guid attribute with a new Guid value
                component.SetAttributeValue("KeyPath", "yes");

                string id = (string)component.Attribute("Id");
                id = id.Replace(".dll", "")
                    .Replace(".icm", "")
                    .Replace(".ini", "")
                    .Replace(".lic", "")
                    .Replace(".ocx", "")
                    .Replace(".exe", "")
                    .Replace(".dll1", "")
                    .Replace(".reg", "")
                    .Replace(".", "");
                id += "File";
                component.SetAttributeValue("Id", id);

            }

            // Get the Fragment element in the document
            XElement fragment = xdoc.Descendants(ns + "Fragment").FirstOrDefault();

            // Create the new XML fragment to append
            XElement newFragment = new XElement(ns + "Fragment",
                new XElement(ns + "ComponentGroup", new XAttribute("Id", "PublishedComponents")
                )
            );

            // Add the new XML fragment as a child element of the Fragment element
            fragment.Add(newFragment);

            // Get the ComponentGroup element in the document
            XElement componentGroup = xdoc.Descendants(ns + "ComponentGroup").FirstOrDefault();

            
            foreach (var component in components)
            {
                // Get the Id attribute value of the component
                string id = (string)component.Attribute("Id");
                // Create the new ComponentRef element to append
                XElement newComponentRef = new XElement(ns + "ComponentRef", new XAttribute("Id", id));
                componentGroup.Add(newComponentRef);
            }
            // Save the modified document to a file
            xdoc.Save("E:\\Personal\\CSDRC\\CSDRC.TestWix\\ComponentsGeneratedws.wxs");

            // Save the WiX XML document.
            //document.Save("ComponentsGeneratedw.wxs");
            //// Specify the path to your WiX source file
            //string wixFilePath = "E:\\Personal\\CSDRC\\CSDRC.TestWix\\ComponentsGeneratedw.wxs";

            //// Specify the new component ID prefix
            //string newComponentIdPrefix = "NewComponentId_";

            //// Load the WiX source file using XDocument
            //XDocument xdoc = XDocument.Load(wixFilePath);

            //// Find all Component elements
            //var componentElements = xdoc.Descendants("Component");

            //// Check if any Component elements exist
            //if (componentElements.Any())
            //{
            //    // Iterate through each Component element and append the new ID attribute
            //    foreach (var componentElement in componentElements)
            //    {
            //        // Generate a unique ID for each component based on the prefix
            //        string newComponentId = newComponentIdPrefix + Guid.NewGuid().ToString("N");

            //        // Append the new ID attribute to the Component element
            //        componentElement.SetAttributeValue("Id", newComponentId);
            //    }

            //    // Save the modified document back to the file
            //    xdoc.Save(wixFilePath);

            //    Console.WriteLine("IDs appended to all components successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("No Component elements found in the WiX source file.");
            //}
        }
    }
}
