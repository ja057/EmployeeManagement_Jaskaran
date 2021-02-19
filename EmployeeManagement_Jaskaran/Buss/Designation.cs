using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement_Jaskaran.Buss
{
    public class Designation
    {
        public int ID { get; set; }
        public int Name { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
