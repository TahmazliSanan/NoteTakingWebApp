using Microsoft.EntityFrameworkCore;
using NoteTakingWebApp.DataAccess.Entities;

namespace NoteTakingWebApp.DataAccess.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Note> Notes { get; set; }
    }
}