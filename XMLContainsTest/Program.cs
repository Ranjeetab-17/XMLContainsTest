using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XMLContainsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ///xml file to be tested 
            if (File.Exists(@"test3.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("test3.xml");

                //Select the book node with the matching attribute value.
                XmlNode nodeToFind;
                XmlElement root = doc.DocumentElement;

                XmlNodeList lstVideos = root.ChildNodes;

                // Selects all the title elements that have an attribute named lang
                nodeToFind = root.SelectSingleNode("//*");

                if (nodeToFind != null)
                {
                    if (ReadXML(nodeToFind))
                    {
                        Console.WriteLine("xml exists");
                    }
                    else {
                        Console.WriteLine("xml does not exists");
                    };
                    // It was found, manipulate it.
                }
                else
                {
                    Console.WriteLine("Invalid xml");
                }
                Console.ReadLine();
            }
        }      

        private static bool ReadXML(XmlNode root)
        {
            if (root is XmlElement)
            {
                ////isExists(root);
                //pass parent xml in which we want to check
                if (!root.isExists("test.xml")) {
                    return false;
                }

                if (root.HasChildNodes)
                    ReadXML(root.FirstChild);
                if (root.NextSibling != null)
                    ReadXML(root.NextSibling);
            }
            else if (root is XmlText)
            { }
            else if (root is XmlComment)
            { }
            return true;
        }       
    }
}
