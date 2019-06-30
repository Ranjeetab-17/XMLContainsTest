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
            if (File.Exists(@"test.xml"))
            {

                XDocument doc = XDocument.Load(@"test2.xml");
                var allElements = doc.Descendants();

                //list
                //XmlDocument xml = new XmlDocument();
                //xml.LoadXml("test.xml");

                ///XmlNodeList xnList = xml.SelectNodes("/Root");
                //  foreach (XmlNode xn in doc.Nodes())
                //{                                        
                ////Console.WriteLine("Name: {0} {1}", firstName, lastName);
                //}
                ////var nodes = doc.Nodes();

                XDocument doc2 = XDocument.Load(@"test2.xml");

                XElement po = doc.Root.Element("Root");


                ///IEnumerable<XElement> list1 = po.Elements();                

                Console.ReadLine();
            }
        }

        public bool isExists(XmlNode nodes)
        {            
            return true;
        }

    }
}
