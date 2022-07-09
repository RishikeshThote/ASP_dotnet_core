using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web_API_Project.Models;

namespace Web_API_Project.Data
{
    public class Web_API_ProjectContext : DbContext
    {
        public Web_API_ProjectContext (DbContextOptions<Web_API_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Web_API_Project.Models.Product> Product { get; set; }
    }
}
