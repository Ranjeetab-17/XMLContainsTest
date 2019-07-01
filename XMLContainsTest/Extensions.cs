using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLContainsTest
{
   public static class Extensions
    {
        public static bool isExists(this XmlNode nodes,string filename)
        {
            if (File.Exists(filename))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filename);

                //Select the book node with the matching attribute value.
                XmlNode nodeToFind;
                XmlElement root = doc.DocumentElement;

                XmlNodeList lstVideos = root.ChildNodes;

                // Selects all the title elements that have an attribute named lang
                nodeToFind = root.SelectSingleNode($"//{nodes.LocalName}");

                if (nodeToFind != null)
                {
                    /////Console.WriteLine($"exists  {nodes.LocalName}");
                    return true;
                }
            }

            return false;
        }
    }
}
