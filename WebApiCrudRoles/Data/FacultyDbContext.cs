using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiCrudRoles.Models;

    public class FacultyDbContext : DbContext
    {
        public FacultyDbContext (DbContextOptions<FacultyDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiCrudRoles.Models.Faculty> Faculty { get; set; } = default!;
    }
