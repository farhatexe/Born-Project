using Born_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Born_Project.Data
{
    public class Born_ProjectDbContext : DbContext
    {
        public Born_ProjectDbContext(DbContextOptions<Born_ProjectDbContext> options) : base(options)
        {

        }

        public DbSet<Project> Project { get; set; }

    }
}
