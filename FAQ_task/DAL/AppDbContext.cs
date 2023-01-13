using FAQ_task.Models;
using Microsoft.EntityFrameworkCore;

namespace FAQ_task.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<FAQ> FAQs { get; set; }


    }
}
