using Microsoft.EntityFrameworkCore;
using MyVet.Web.Date.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Date
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }

        public DbSet<Owner> Owners { get; set; }
    }
}
