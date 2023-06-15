using Microsoft.EntityFrameworkCore;

using ModernVilla_VillaAPI.Models;

namespace ModernVilla_VillaAPI.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }
        public DbSet<Villa> Villas { get; set; }
    }
}
