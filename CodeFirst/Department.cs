using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public virtual List<Employee> Employees { get; set; }

        public Department()
        {
            this.Employees = new List<Employee>();
        }        
    }
}