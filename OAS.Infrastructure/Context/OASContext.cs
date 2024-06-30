using System;
using Microsoft.EntityFrameworkCore;
using OAS.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OAS.Domain.Core;


namespace OAS.Infrastructure.Context
{
    public class OASContext : DbContext
    {
        public OASContext(DbContextOptions<OASContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}

