using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TravelAgency.Models;

    public class StoreDbContext : DbContext
    {
        public StoreDbContext (DbContextOptions<StoreDbContext> options)
            : base(options)
        {
        }

        public DbSet<TravelAgency.Models.Store> Store { get; set; } = default!;
    }
