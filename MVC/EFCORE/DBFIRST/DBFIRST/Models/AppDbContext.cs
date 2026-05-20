using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;

namespace DBFIRST.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        DbSet<Student> Students { get; set; }
    }
}
