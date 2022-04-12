using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Xml.Serialization;
using System.IO;


namespace XmlXsdClassUsage
{
    class Program
    {
        static void Main(string[] args)
        {



            var docganesh = new Doctor
            {                
               Name = "Ganesh N",
               Department = "Outpatient Department"
            };


            var serializer = new XmlSerializer(typeof(Doctor));
            using (var stream = new StreamWriter(@"E:\csharp\xml_csharp\xml_xsd\xml_xsd_03\OneDoctor.xml"))
            serializer.Serialize(stream, docganesh);
            
            Console.WriteLine("Doctor details Written successfully inside the XML file.");

            Console.Read();
        }
    }
}
