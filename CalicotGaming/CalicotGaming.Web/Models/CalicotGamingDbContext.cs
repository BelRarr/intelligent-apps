using Microsoft.EntityFrameworkCore;

namespace CalicotGaming.Web.Models
{
    public class CalicotGamingDbContext : DbContext
    {
        public CalicotGamingDbContext(DbContextOptions<CalicotGamingDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product>? Products { get; set; }
    }
}


// dotnet ef dbcontext scaffold "Server=localhost;Database=CalicotGaming;User Id=sa;Password=Password123;" Microsoft.EntityFrameworkCore.SqlServer -o Models