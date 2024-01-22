using GraphQLNet.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLNet.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<Company>? Companies { get; set; }
        public DbSet<Opportunity>? Opportunities { get; set; }
    }
}


