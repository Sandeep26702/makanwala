using makanwala.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;

namespace makanwala.Models
{
    public class AppuserDbContext : DbContext
    {
        public AppuserDbContext(DbContextOptions<AppuserDbContext> options) : base(options)
        {
        }

        public DbSet<Property> Pro { get; set; }


    }
}
