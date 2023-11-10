using Api.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DataAccessLayer.Context
{
    public class AppliactionContext:DbContext
    {
        public AppliactionContext(DbContextOptions<AppliactionContext> options):base(options)
        {
            
        }

        public DbSet<Doctor> Doctors { get; set; }
    }
}
