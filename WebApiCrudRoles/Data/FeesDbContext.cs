using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiCrudRoles.Models;

    public class FeesDbContext : DbContext
    {
        public FeesDbContext (DbContextOptions<FeesDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiCrudRoles.Models.Fees> Fees { get; set; } = default!;
    }
