using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement_Jaskaran.Buss
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int DepartmentID { get; set; }
        public int DesignationID { get; set; }
        public Department Department { get; set; }
        public Designation Designation { get; set; }
    }
}
