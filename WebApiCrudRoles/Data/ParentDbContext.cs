using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiCrudRoles.Models;

    public class ParentDbContext : DbContext
    {
        public ParentDbContext (DbContextOptions<ParentDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiCrudRoles.Models.Parent> Parent { get; set; } = default!;
    }
