using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodeFirst
{
    /*
     * DbContext() - A DbContext instance represents a combination of the Unit of Work and Repository patterns
     *               such that it can be used to query from a database and group together changes that will be
     *               written back to the store as a unit. DbContext is conceptually similar to ObjectContext.
     * Created on 28/09/2014
     */
    public class EmployeeDBContext : DbContext
    {
        /* DbSet<> - A DbSet represents the collection of all entities in the context, or that can be queried
         *           from the database, of a given type. DbSet objects are created from a DbContext using the
         *           DbContext.Set method
         * Created on 28/09/2014
         */
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}