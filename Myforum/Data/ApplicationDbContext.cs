using Microsoft.EntityFrameworkCore;
using Myforum.Model;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Topic> Topics { get; set; }
}
