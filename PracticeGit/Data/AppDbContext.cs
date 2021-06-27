using Microsoft.EntityFrameworkCore;
using PracticeGit.Models;

namespace PracticeGit.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ProductModel> Products { get; set; }
    }
}