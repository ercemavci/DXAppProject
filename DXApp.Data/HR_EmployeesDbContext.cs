using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApp.Data
{
    public class HR_EmployeesDbContext : DbContext
    {
        public HR_EmployeesDbContext()
        {
            this.Database.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        }
        public DbSet<HR_Employees> DxDBContent { get; set; }
        public DbSet<CounterClass> DxDBContents { get; set; }
    }
}
