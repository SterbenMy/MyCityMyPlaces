using Microsoft.EntityFrameworkCore;
using MyCityMyPlaces.Models;

namespace MyCityMyPlaces.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
        public DbSet<User> Users { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<Location> Locations { get; set; } 
    }
}