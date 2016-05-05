using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodeFirst
{
    /*
     * DropCreateDatabaseIfModelChanges<TContext> class - An implementation of IDatabaseInitializer that will DELETE, RECREATE
     *      and optionally re-seed the database only if the model has changed since the database was created.
     * Seed() - A method that should be overridden to actually add data to the context for seeding. 
     * Created on 27/09/2014
     */
    public class EmployeeDBContextSeeder : DropCreateDatabaseIfModelChanges<EmployeeDBContext>
    {
        protected override void Seed(EmployeeDBContext context)
        {
            //using (context)
            //{
                Department department1 = new Department()
                {
                    Name = "IT",
                    Location = "New York",
                    Employees = new List<Employee>()
                    {
                        new Employee()
                        {
                          FirstName = "Mark", LastName = "Hasting", Gender = "Male", Salary = 60000, JobTitle = "Developer"
                        },

                        new Employee()
                        {
                            FirstName = "Ben", LastName = "Hoskins", Gender = "Male", Salary = 70000, JobTitle = "Sr. Developer"
                        },

                         new Employee()
                        {
                            FirstName = "John", LastName = "Stanmore", Gender = "Male", Salary = 80000, JobTitle = "Project Manager"
                        }
                    }
                  };

                Department department2 = new Department()
                {
                    Name = "HR",
                    Location = "London",
                    Employees = new List<Employee>()
                    {
                        new Employee()
                        {
                          FirstName = "Phillip", LastName = "Hasting", Gender = "Male", Salary = 45000, JobTitle = "Recruiter"
                        },

                        new Employee()
                        {
                            FirstName = "Mary", LastName = "Lambeth", Gender = "Female", Salary = 30000, JobTitle = "Sr. Recruiter"
                        }
                    }
                };

                Department department3 = new Department()
                {
                    Name = "Payroll",
                    Location = "Sydney",
                    Employees = new List<Employee>()
                    {
                        new Employee()
                        {
                          FirstName = "Steve", LastName = "Pound", Gender = "Male", Salary = 45000, JobTitle = "Sr. Payroll Admin"
                        },

                        new Employee()
                        {
                            FirstName = "Valerie", LastName = "Vikings", Gender = "Female", Salary = 35000, JobTitle = "Payroll Admin"
                        }
                    }
                };

                context.Departments.Add(department1);
                context.Departments.Add(department2);
                context.Departments.Add(department3);
                base.Seed(context);
            //}
        }
    }
}