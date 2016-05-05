using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeFirst
{
    /*
     * Code First Approach - This project will use the Employee.cs and Department.cs to create 
     *                       EFByPragim database(Web.config) for Departments and Employees table
     *                       using Entity Framework(EmployeeDBContext).
     *                     - To display, it use Object Data Source control(ObjectDataSource1) 
     *                       to retrieve the data from Employee.cs and Department.cs 
     *                       into Grid View control(GridView1) and sub-GridView(GridView2) into the 
     *                       browser from EFByPragim database.
     * Reference : Z:\ASPNet\ASP.NET MVC 4.0\Self_Project\Entity Framework 4\CodeFirst\Fabio Copel\EFCodeFirstByPragim.sln
     *             [Use this console application to test Employee.cs and Department.cs class to create tables in database
     *             EmployeeDatabaseVer1.mdf]
     *             Z:\ASPNet\ASP.NET MVC 4.0\Self_Project\Entity Framework 4\CodeFirst\Fabio Copel\CodeFirstNewStudentDatabaseVer1
     *             Z:\ASPNet\ASP.NET MVC 4.0\Self_Project\Entity Framework 4\CodeFirst\Fabio Copel\CodeFirstNewStudentDatabaseVer2
     *             [Use this console application to learn using console application to create tables in the database
     *             (StudentDatabaseVer1 and StudentDatabaseVer2)]
     * Created on 27/09/2014
     */
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //using (EmployeeDBContext employeeDBContext = new EmployeeDBContext())
            //{
            //    Department department = new Department()
            //    {
            //        Name = "IT",
            //        Location = "New York"
            //    };

            //    Employee employee = new Employee()
            //    {
            //        FirstName = "Mark",
            //        LastName = "Hastings",
            //        Gender = "Male",
            //        Salary = 60000
            //    };

            //    department.Employees.Add(employee);

            //    // Add the department object into DBContext
            //    employeeDBContext.Department.Add(department);
            //    employeeDBContext.SaveChanges();
            //}
        }
    }
}