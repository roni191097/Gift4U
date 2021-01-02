using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gift4U.Models;

namespace Gift4U.Data
{
    public class Gift4UContext : DbContext
    {
        public Gift4UContext (DbContextOptions<Gift4UContext> options)
            : base(options)
        {
        }

        public DbSet<Gift4U.Models.Category> Category { get; set; }
    }
}
