using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TravelAgency.Models;

    public class OrderDbContext : DbContext
    {
        public OrderDbContext (DbContextOptions<OrderDbContext> options)
            : base(options)
        {
        }

        public DbSet<TravelAgency.Models.Order> Order { get; set; } = default!;
    }
