using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Myforum.Areas.Identity.Data;

namespace Myforum.Areas.Identity.Data;

public class RazorPagesUsers : IdentityDbContext<RazorUsers>
{
    public RazorPagesUsers(DbContextOptions<RazorPagesUsers> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

    }
}
