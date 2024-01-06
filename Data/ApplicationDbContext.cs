using Microsoft.EntityFrameworkCore;
using DoHuyHoang781.Models;

namespace DoHuyHoang781.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<DoHuyHoang781.Models.Student> Student { get; set; } = default!;

    }
}