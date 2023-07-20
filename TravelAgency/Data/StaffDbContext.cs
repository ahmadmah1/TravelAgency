using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TravelAgency.Models;

    public class StaffDbContext : DbContext
    {
        public StaffDbContext (DbContextOptions<StaffDbContext> options)
            : base(options)
        {
        }

        public DbSet<TravelAgency.Models.Staff> Staff { get; set; } = default!;
    }
