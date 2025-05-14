

using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using UserDetails.Models;

namespace UserDetails.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> users { get; set; }
    }
}


