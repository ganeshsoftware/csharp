using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager
{
    public class Employee
    {
        public Int32 Id { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public string Department { get; set; }
        public bool BinaryFormat { get; set; }
        public bool XmlFormat { get; set; }

    }
}
