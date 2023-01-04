using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenThuyDung124.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<NguyenThuyDung124.Models.CompanyNTD124> CompanyNTD124 { get; set; } = default!;

        public DbSet<NguyenThuyDung124.Models.NTD0124> NTD0124 { get; set; } = default!;
    }
