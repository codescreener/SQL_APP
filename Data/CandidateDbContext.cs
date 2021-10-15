using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Applications.Models;

namespace Applications.Data
{
    public class CandidateDbContext:DbContext
    {

        public CandidateDbContext(DbContextOptions<CandidateDbContext> options):base(options)
        { 

        }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Emp_Dept> Emp_Depts { get; set; }

    }
}
